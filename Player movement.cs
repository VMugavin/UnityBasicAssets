using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 20f;
    public GameObject bullet;
    private Vector2 moveVector;
    //public GameObject Player;

    // Update is called once per frame
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()

    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //rotation
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        moveVector.x = Input.GetAxis("Horizontal"); //movement
        moveVector.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
       
        if (Input.GetKeyDown(KeyCode.Mouse0)) //shooting
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

}
