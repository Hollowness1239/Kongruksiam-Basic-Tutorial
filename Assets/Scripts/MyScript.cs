using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //รับค่าจาก keyboard
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, y, z);

        //รับค่าจาก Mouse
        //Left Mouse
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0f, 1f * speed, 0f);
        }
        //Right Mouse
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0f, -1f * speed, 0f);
        }
        //Middle Mouse
        if (Input.GetMouseButtonDown(2))
        {
            transform.Rotate(-1f * speed, 0f, 0f);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer(movement);
    }

    private void MovePlayer(Vector3 direction)
    {
        // rb.velocity = direction * speed;
        // rb.MovePosition(transform.position + (direction*speed * Time.deltaTime));\
        rb.AddForce(direction * speed);
    }
}
