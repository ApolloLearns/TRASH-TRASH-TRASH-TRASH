using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher_Script : MonoBehaviour
{
    //public GameObject launcher;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
