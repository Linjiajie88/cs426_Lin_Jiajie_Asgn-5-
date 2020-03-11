using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LookAt;
    public GameObject[] Myarry;

    // Update is called once per frame
    void Update()
    {
        if (LookAt == null)
        {
            Myarry = GameObject.FindGameObjectsWithTag("Player");
            if (Myarry != null)
            {
                Debug.Log("hello" + Myarry.Length);
                LookAt = Myarry[0];
                this.transform.rotation = LookAt.transform.rotation;
            }
            else
            {
                Debug.Log("hello else"+Myarry.Length);
                //LookAt = Myarry[0];
                //this.transform.rotation = LookAt.transform.rotation;
            }

        }
        else
        {
            Debug.Log("move");
            this.transform.rotation = LookAt.transform.rotation;
        }
            
        
    }
}
