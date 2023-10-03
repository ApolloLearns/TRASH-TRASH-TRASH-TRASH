using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyingguuuuo : MonoBehaviour
{
//public GameObject projectile;
public float upperbounds = 40f;
public float lowBounds = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > lowBounds){Destroy(gameObject);
    } 
    //else if (transform.position.z < upperbounds) 
    //{
        //Destroy(gameObject);
    //}
    }
}

