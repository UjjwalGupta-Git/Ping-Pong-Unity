using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(15f, 0f);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
