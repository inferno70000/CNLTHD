using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce = 500f;
    public float speed = 5f;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new(direction * speed, rigid.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(new(rigid.velocity.x, jumpForce));
        }
    }
}
