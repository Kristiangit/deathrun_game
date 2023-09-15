using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5f;
    private Vector3 targetPos;
    private Rigidbody rb;

    public Vector3 obsPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        obsPos = GameObject.Find("environment").transform.position;
        transform.position = new Vector3(obsPos.x + 1f, obsPos.y, 0);
    }


    // Update is called once per frame
    void Update()
    {
        float velo_X = 0f;
        float velo_Y = 0f;

        float obsX = obsPos.x +1f;
        float obsY = obsPos.y;

        targetPos.z = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow)) // Up
        {
            velo_Y = 4f;
            targetPos.y = obsY + 0.5f;  
        }

        if (Input.GetKey(KeyCode.DownArrow)) // Down
        {
            velo_Y = -4f;
            targetPos.y = obsY - 0.5f;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // Left
        {
            velo_X = -4f;
            targetPos.x = obsX - 0.5f;
        }

        if (Input.GetKey(KeyCode.RightArrow)) // Right
        {
            velo_X = 4f;
            targetPos.x = obsX + 0.5f;
        }



        if (transform.position == targetPos)
        {
            Debug.Log("target hit");
            Debug.Log(transform.position);
            Debug.Log(targetPos);

            velo_X = 0f;
            velo_Y = 0f;
            transform.position = targetPos;
        }


        rb.velocity = new Vector3(velo_X, velo_Y, MovementSpeed);

        //Debug.Log(rb.velocity);

    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("cage"))
        {
            obsPos = other.gameObject.transform.position;
        }
    }
}
