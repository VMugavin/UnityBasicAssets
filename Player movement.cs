using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;
    private Vector2 moveVector;
    public GameObject Player;

    // Update is called once per frame
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()

    { 
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
/*    public Vector2 GetPlayerTransform()
    {

        {
            return transform.position;
        }
    }*/

}
