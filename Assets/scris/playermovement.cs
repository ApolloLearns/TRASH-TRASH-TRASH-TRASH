using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float horiInput;
    public float vertInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // keep player inbounds

        //idkkk
        
        //movement(?)
        horiInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * horiInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * vertInput * Time.deltaTime * speed);
    }


}