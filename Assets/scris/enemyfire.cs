using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire : MonoBehaviour
{
    public Transform gun;
    public GameObject bulletes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 2, 10.0f); 
        //Fire a bullet every 2 seconds starting immediately

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bulletes ,gun.transform.position , gun.transform.rotation);
    }
}