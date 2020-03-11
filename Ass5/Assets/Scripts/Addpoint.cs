using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Addpoint : NetworkBehaviour
{
    public Text scoreText;
    public AudioSource goodcatch;
    public AudioSource badcatch;

    bool stopAdding;

    [SyncVar]
    int score;
    // Start is called before the first frame update
    void Start()
    {
        goodcatch.enabled = true;
        badcatch.enabled = true;
        stopAdding = false;
        score = 0;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GoodCache")) {
            if (!stopAdding)
                Add(1);
                
                goodcatch.Play();

        } else if (collision.gameObject.CompareTag("BadCache")) {
            if (!stopAdding)
                Add(-1);
                
                badcatch.Play();
        }
    }

    IEnumerator KillPlayer() {
        yield return new WaitForSeconds(5f);
        NetworkServer.Destroy(this.gameObject);
    }

   public void Add(int n)
    {
        if (score <= -4 || score >= 4) return;

        score += n; // tack on points

        if(score == 4)
        {
            scoreText.text = "You win!";
            StartCoroutine("KillPlayer");
            stopAdding = true;
        } else if (score == -4)
        {
            scoreText.text = "You lose!";
            StartCoroutine("KillPlayer");
            stopAdding = true;
        }
        else
        {
            scoreText.text = "Score: " + score;
        }
    }
}
