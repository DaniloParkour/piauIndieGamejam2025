using System;
using UnityEngine;

public class PlayerMoviments : MonoBehaviour
{

    public float speed = 12f;
    public float jump_forc = 8;
    private Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        rigidbody.linearVelocity = new Vector2(horizontal * speed, rigidbody.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space) && (rigidbody.linearVelocityY < 0.01f && rigidbody.linearVelocityY > -0.01f))
        {
            rigidbody.AddForce(Vector2.up * jump_forc, ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
