using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling : MonoBehaviour
{
    public GameObject rb;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void FireBall()
    {
        rb.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(0, 0, -5000));
        //rb.GetComponent<Rigidbody>().AddForce(new Vector3(10000, 0, 0));
        //rb.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(100, 0, 0));
    }
}
