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
        if (Input.GetButton("Tembak"))
        {
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            //Temporary_Bullet_Handler = Instantiate(laser, laser_emitter.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
            Temporary_Bullet_Handler = Instantiate(laser, laser_emitter.transform.position, laser_emitter.transform.rotation) as GameObject;
            //Temporary_Bullet_Handler = Instantiate(laser, laser_emitter, Quaternion.Euler(new Vector3(45, 0, 0)));

            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            //Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
            //Temporary_Bullet_Handler.transform.rotation = spawnRotation;

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            //Rigidbody Temporary_RigidBody;
            //Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            //Temporary_RigidBody.AddForce(transform.forward * Laser_Forward_Force);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_Handler, 0.1f);
        }
    }
}
