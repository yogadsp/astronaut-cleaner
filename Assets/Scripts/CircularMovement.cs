using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    [SerializeField]
    Transform rotationCenter;

    [SerializeField]
    public float rotationRadius;
    public float angularSpeed;

    float posX, posY, angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.x + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * angularSpeed;

        if(angle >= 360f)
        {
            angle = 0f;
        }

    }
}
