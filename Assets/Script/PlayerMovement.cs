using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5f;
    private Vector3 pos;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {

        pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow)) // Up
        {
            pos.y = 1.5f;  
        }

        if (Input.GetKey(KeyCode.DownArrow)) // Down
        {
            pos.y = 0.5f;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // Left
        {
            pos.x = 9.5f;
        }

        if (Input.GetKey(KeyCode.RightArrow)) // Right
        {
            pos.x = 10.5f;
        }





        this.transform.position = pos;

        rb.velocity = new Vector3(0, 0, 5);

        //Debug.Log(rb.velocity);

    }
}
