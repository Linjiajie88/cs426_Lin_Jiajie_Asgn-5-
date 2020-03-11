using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ShootObjects : NetworkBehaviour
{
    [SerializeField]
    GameObject[] objectSpawnPoints;

    [SerializeField]
    GameObject badCache;

    [SerializeField]
    GameObject goodCache;

    [SerializeField]
    GameObject speedCache;

    public static bool justShot = false;

    [SerializeField]
    //public static bool[] takenSpots = new bool[12];

    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!justShot) {
            // shoot!
            justShot = true;
            StartCoroutine("CmdDoShoot");
        }
    }

    IEnumerator CmdDoShoot() {
        CmdSpawnObj();
        yield return new WaitForSeconds(.2f);
        justShot = false;
    }

    [Command]
    void CmdSpawnObj() {
        // Choose random spawn point
        int randIndex = Random.Range(0, objectSpawnPoints.Length);

        GameObject randomSpawnPoint = objectSpawnPoints[randIndex];

        // Which cache are we going to shoot?
        GameObject shootingObject;

        // The chance for a goodCache to come.
        int randNum = Random.Range(0, 5);
        if (randNum == 0)
            shootingObject = goodCache;
        else
            shootingObject = badCache;

        // chance for speed cache
        int randNum2 = Random.Range(0, 15);
        
        if (randNum2 == 0)
            shootingObject = speedCache;

        GameObject go = Instantiate(shootingObject, randomSpawnPoint.transform.position, randomSpawnPoint.transform.rotation);
        go.GetComponent<Rigidbody>().velocity -= transform.forward * 50;
        NetworkServer.Spawn(go);
        Destroy(go, 2f);
    }
}
