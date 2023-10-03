using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletes;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float horizontalInput;


    //private float bounds = 20f;
    //private float lowerBounds = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Translate(Vector3.forward * Time.deltaTime * projSpeed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
       if (transform.position.x < xRange)
       {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }

       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletes, transform.position, bulletes.transform.rotation);
        }
        
    }

}






