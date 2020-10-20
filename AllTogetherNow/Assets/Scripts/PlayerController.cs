﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 movement;
    public float speed;
    public GameObject camera;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + Time.fixedDeltaTime * speed * movement);
        rb2d.MovePosition(rb2d.position + Time.fixedDeltaTime * speed * movement);
    }

    private void LateUpdate()
    {
        camera.transform.position = transform.position + new Vector3(0,0, -1);
    }
}