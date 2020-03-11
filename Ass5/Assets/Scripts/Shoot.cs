using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Shoot : MonoBehaviour
{

    public float thrust = 1.0f;
    Rigidbody rb;

    bool shot = false;

    public int index;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // if (!shot) {
        //     rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
        //     shot = true;
        // }
    }

    private void OnTriggerEnter(Collider other) {
        if (!other.gameObject.CompareTag("CacheData")) {
        }
    }
}
