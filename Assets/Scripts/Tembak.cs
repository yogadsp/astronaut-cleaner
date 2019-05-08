using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject laser_emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject laser;

    //Enter the Speed of the Bullet from the Component Inspector.
    //public float Laser_Forward_Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            GameObject Temporary_Bullet_Handler;

            Temporary_Bullet_Handler = Instantiate(laser, laser_emitter.transform.position, laser_emitter.transform.rotation) as GameObject;

            Destroy(Temporary_Bullet_Handler, 0.1f);
        }
    }
}
