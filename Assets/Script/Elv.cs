using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elv : MonoBehaviour
{
    public int isUp;
    public int isRotZ;

    const float ELV_SPEED = 3.0f;
    const float ELV_ROT_SPEED = 10.0f;

    private void Elv_Up() { transform.position += new Vector3(0, ELV_SPEED * Time.deltaTime, 0); }
    private void Elv_Down() { transform.position -= new Vector3(0, ELV_SPEED * Time.deltaTime, 0); }
    private void Elv_RotUp() { transform.Rotate(Vector3.forward * (Time.deltaTime * ELV_ROT_SPEED) ); }
    private void Elv_RotDown() { transform.Rotate(-Vector3.forward * (Time.deltaTime * ELV_ROT_SPEED) ); }

    void Awake()
    {
        isUp = 0;
        isRotZ = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        switch (isUp)
        {
            case 0: break;
            case 1: // 올라가기

                Elv_Up();
                if (transform.position.y >= 0.175f)
                {
                    isUp = 0;
                    isRotZ = 1;
                }

                break;

            case 2: // 내려가기
                Elv_Down();

                if (transform.position.y <= -3.18f)
                {
                    isUp = 0;
                    isRotZ = 2;
                }
                break;
        }

        switch( isRotZ )
        {
            case 0: break;
            case 1: // 내리기

                Elv_RotDown();
                if ( transform.eulerAngles.z <= 355.0f)
                    isRotZ = 0;
                
                break;

            case 2: // 올리기

                Elv_RotUp();
                if (transform.eulerAngles.z >= 359.9f)
                    isRotZ = 0;
                
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
