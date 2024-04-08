using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    private Rigidbody2D Cam;
    private Vector2 moveVector;
    private GameObject player;
    private Camera CamSet;
    float speed;
    
    //Vector2 target = new Playermovement.GetPlayerTransform();

    // Start is called before the first frame update
    void Start()
    {
        Cam = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        CamSet = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = player.transform.position.x - transform.position.x;
        moveVector.y = player.transform.position.y - transform.position.y;
        speed = Math.Abs((moveVector.x + moveVector.y) / 2);
        Cam.MovePosition(Cam.position + moveVector * speed * 5 * Time.deltaTime);
        CamSet.orthographicSize = 3 + speed / 2;
    }
}
