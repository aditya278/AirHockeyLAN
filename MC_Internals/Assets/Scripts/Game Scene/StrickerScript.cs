﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrickerScript : MonoBehaviour
{
    public Vector2 dir;
    public Rigidbody2D rb;
    public float maxSpeed = 50f;

    // Use this for initialization
    void Start()
    {

        int random = Random.Range(-1, 1);

        if(random < 0)
        {
            dir = new Vector2(0f, 1f);

        } else
        {
            dir = new Vector2(0f, -1f);
        }

        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(dir * maxSpeed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.transform.tag == "Goal1")
        {

        }

        if (col.gameObject.transform.tag == "Goal2")
        {

        }

    }
}
