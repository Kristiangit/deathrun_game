using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5f;
    private Vector3 targetPos;
    private Rigidbody rb;

    public Vector3 obsPos;
    private float seconds = 0f;
    private float velo_X = 0f;
    private float velo_Y = 0f;
    private bool timer = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        obsPos = GameObject.Find("environment").transform.position;
        Debug.Log(obsPos);
        transform.position = new Vector3(obsPos.x + 1f, obsPos.y, 0);
        targetPos = transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        float obsX = obsPos.x +1f;
        float obsY = obsPos.y;

        targetPos.z = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y != obsY + 0.5f) // Up
        {
            velo_Y = 8f;
            targetPos.y = obsY + 0.5f;
            timer = true;

            Debug.Log("up hit");
            Debug.Log(transform.position);
            Debug.Log(targetPos);

            
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y != obsY - 0.5f) // Down
        {
            velo_Y = -8f;
            targetPos.y = obsY - 0.5f;
            timer = true;
            
            Debug.Log("down hit");
            Debug.Log(transform.position);
            Debug.Log(targetPos);

        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x != obsX - 0.5f) // Left
        {
            velo_X = -8f;
            targetPos.x = obsX - 0.5f;
            timer = true;


            Debug.Log("left hit");
            Debug.Log(transform.position);
            Debug.Log(targetPos);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x != obsX + 0.5f) // Right
        {
            velo_X = 8f;
            targetPos.x = obsX + 0.5f;
            timer = true;

            Debug.Log("right hit");
            Debug.Log(transform.position);
            Debug.Log(targetPos);
        }



        //Debug.Log(rb.velocity);
        if (timer)
        {
            seconds += Time.deltaTime;
        }
        
        if (seconds >= 0.125f)
        {
            velo_X = 0f;
            velo_Y = 0f;
            transform.position = targetPos;
            Debug.Log(targetPos);
            seconds = 0f;
            timer = false;
        }
        rb.velocity = new Vector3(velo_X, velo_Y, MovementSpeed);

    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("cage"))
        {
            obsPos = other.gameObject.transform.position;
            Debug.Log("new envo");
            Debug.Log(obsPos);
        }
    }
}
