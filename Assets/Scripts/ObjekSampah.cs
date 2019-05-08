using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekSampah : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject[] objek;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject pisang;
    int countObject = 0;
    float timer = 0f;
    float timerPlay = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        countObject++;

        timer += Time.deltaTime;
        timerPlay += Time.deltaTime;

        int rando = Random.Range(0, 2);

        if(timer > 4)
        {
            GameObject pisang_temp = Instantiate(pisang, objek[rando].transform.position, objek[rando].transform.rotation) as GameObject;
            timer = 0;
        }
        else if(timer > 2 && timerPlay > 20)
        {
            GameObject pisang_temp = Instantiate(pisang, objek[rando].transform.position, objek[rando].transform.rotation) as GameObject;
            timer = 0;
        }
        

    }
}
