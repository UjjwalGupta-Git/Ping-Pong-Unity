using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    private Rigidbody2D PlayerTwo;
    public Rigidbody2D Ball;

    void Start()
    {
        PlayerTwo = this.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerTwo.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerTwo.velocity = new Vector2(0f, -5f);
        }
        else
        {
            PlayerTwo.velocity = Vector2.zero;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            Ball.velocity = new Vector2(-15f, Ball.velocity.y);
        }
    }

}
