using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elv : MonoBehaviour
{
    public int isUp;
    public int isRotZ;
    private int upDelay;

    void Awake()
    {
        isUp = 0;
        isRotZ = 0;
        upDelay = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        switch (isUp)
        {
            case 0:

                break;

            case 1: // 올라가기
                if (upDelay++ > 50)
                {
                    transform.position += new Vector3(0, 1.0f * Time.deltaTime, 0);

                    if (transform.position.y >= 0.16f)
                    {
                        isUp = 0;
                        upDelay = 0;
                        isRotZ = 1;
                    }
                }
                break;

            case 2: // 내려가기
                if (upDelay++ > 100)
                {
                    transform.position -= new Vector3(0, 1.0f * Time.deltaTime, 0);

                    if (transform.position.y <= -3.2f)
                    {
                        isUp = 0;
                        upDelay = 0;
                        isRotZ = 2;
                    }
                }
                break;
        }

        switch( isRotZ )
        {
            case 0:

                break;

            case 1: // 내리기
                
                transform.Rotate(-Vector3.forward * Time.deltaTime);

                if ( transform.eulerAngles.z <= 357.0f)
                {
                    isRotZ = 0;
                    isUp = 2;
                }
                break;

            case 2: // 올리기

                transform.Rotate( Vector3.forward * Time.deltaTime);
                if (transform.eulerAngles.z >= 359.9f)
                {
                    isRotZ = 0;
                    isUp = 0;
                }
                break;
        }
    }   
}
