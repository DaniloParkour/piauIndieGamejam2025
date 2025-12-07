using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMoviments : MonoBehaviour
{

    public float speed = 12f;
    public float jump_forc = 8;
    public float imortalDuration = 2f;
    public GameObject shield;
    private Rigidbody2D rigidbody;
    public bool Imortal = false;
    public float contadorImortal = 0;
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
                contadorImortal = 6.999f;
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
            rigidbody.linearVelocity = new Vector2(0, rigidbody.linearVelocityY);
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("EndGame"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
