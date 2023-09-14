using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5f;
    private Vector3 pos;
    private Rigidbody rb;

    public float obsPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(obsPos, obsPos -1f, 0);
    }


    // Update is called once per frame
    void Update()
    {
        float obsX = obsPos;
        float obsY = obsPos -1f;

        pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow)) // Up
        {
            pos.y = obsY + 0.5f;  
        }

        if (Input.GetKey(KeyCode.DownArrow)) // Down
        {
            pos.y = obsY - 0.5f;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // Left
        {
            pos.x = obsX - 0.5f;
        }

        if (Input.GetKey(KeyCode.RightArrow)) // Right
        {
            pos.x = obsX + 0.5f;
        }





        this.transform.position = pos;

        rb.velocity = new Vector3(0, 0, 5);

        //Debug.Log(rb.velocity);

    }
}
