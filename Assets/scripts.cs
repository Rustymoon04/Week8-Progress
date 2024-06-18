using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move object forward along the z axis, 1 unit per sec
        //Vector3.forward = Vector3(0,0,1)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));

            //Alternative Code 
            //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) 
        { 
            transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
            
            //rotation
            //transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (Time.deltaTime * moveSpeed));

            //rotation
            //transform.Rotate(Vector3.down, Time.deltaTime + rotSpeed);
        }

    }
}
