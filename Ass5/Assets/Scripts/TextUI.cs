using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public Text mytext;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Vector3 textPos = Camera.main.WorldToScreenPoint(this.transform.position);
        mytext.transform.position = textPos;
    }
}
