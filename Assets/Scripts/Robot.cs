﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public Vector3 direction = Vector3.zero, target = Vector3.zero;
    public float maxSpeed;
    float speed;
    static Vector3 north = new Vector3(0, 1, 0);
    static Vector3 east = new Vector3(1, 0, 0);
    static Vector3 south = new Vector3(0, -1, 0);
    static Vector3 west = new Vector3(-1, 0, 0);
    static Vector3[] directions = new Vector3[] { north, east, south, west };

    // Start is called before the first frame update
    void Start()
    {
        direction = RandomDirection();
    }

    public Vector2 RandomDirection()
    {
        return directions[(int)(Random.value * (directions.Length - 0.1f))];
    }

    // Update is called once per frame
    void Update()
    {

        speed = Mathf.Min(Vector2.Distance(transform.position, target), 1) * maxSpeed;
        transform.position += speed * direction * Time.deltaTime;
        GameController.instance.CheckBounds(this);
    }

    public void RunProgram()
    {
        transform.position = target;
        direction = RandomDirection();
        //direction = north;
        //direction = east;
        //direction = south;
        //direction = west;
        target = transform.position + direction;
        target = new Vector3(Mathf.Round(target.x), Mathf.Round(target.y), Mathf.Round(target.z));

    }
}
