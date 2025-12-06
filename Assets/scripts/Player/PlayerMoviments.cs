using System;
using UnityEngine;

public class PlayerMoviments : MonoBehaviour
{

    public float speed = 12f;
    public float jump_forc = 8;
    public float imortalDuration = 2f;
    public GameObject shield;
    private Rigidbody2D rigidbody;
    public bool Imortal = false;
    private float contadorImortal = 5f;
    private float imortalTime = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        imortalTime = imortalDuration;
        shield.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (contadorImortal <= 0)
            {
                Imortal = true;
                contadorImortal = 10;
                shield.SetActive(true);
            }
        }

        contadorImortal -= Time.deltaTime;

        if(Imortal == true)
        {
            imortalTime -= Time.deltaTime;
            if(imortalTime <= 0)
            {
                Imortal = false;
                imortalTime = imortalDuration;
                shield.SetActive(false);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") && !Imortal)
        {

            Destroy(this);
        }
    }
}
