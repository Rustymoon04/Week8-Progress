using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float movespeed;
    public float rotationSpeed;
    public float jumpForce;
    public Rigidbody rigidBody;

    public int score;
    public float baseMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        baseMoveSpeed = movespeed;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * movespeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation,0);

        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector3(0,jumpForce,0),ForceMode.Impulse);
        }

    }
}
