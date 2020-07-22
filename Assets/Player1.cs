using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D PlayerOne;
    public Rigidbody2D Ball;

    void Start()
    {
        PlayerOne = this.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerOne.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayerOne.velocity = new Vector2(0f, -5f);
        }
        else
        {
            PlayerOne.velocity = Vector2.zero;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            Ball.velocity = new Vector2(15f, Ball.velocity.y);
        }
    }
}
