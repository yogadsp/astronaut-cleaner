using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekSampah : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject[] objek;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject pisang;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() { 
    
        int rando = Random.Range(0, 2);

        GameObject pisang_temp = Instantiate(pisang, objek[rando].transform.position, objek[rando].transform.rotation) as GameObject;

    }
}
