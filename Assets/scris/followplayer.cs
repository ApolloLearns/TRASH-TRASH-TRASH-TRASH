using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    //public GameObject player;
    public Transform player;
    public Transform MainCamera;
    public float x = 26.846f;
    public float y = 3.71f;
    public float z = 1.389f;
    
    //private Vector3 offset = new Vector3 (12.48f, 2.59f, 5.26f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
        //13.433 269.094 0.124
        MainCamera.position = player.position + new Vector3(x, y, z);
        //Quaternion camRotation = Quaternion.Euler(-1.757f, -88.449f, -0.541f); 

    }
}
