using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float flying = 12f;
    private float stopping = 0f;
    private Rigidbody2D rigidbody;

    public float minX = -11f;
    public float maxX = 11f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        float novoX = Random.Range(minX, maxX);
        transform.position = new Vector3(novoX, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rigidbody.linearVelocity = new Vector2(horizontal * stopping, rigidbody.linearVelocityY);

        if (rigidbody.linearVelocityY < 0.01f && rigidbody.linearVelocityY > -0.01f)
        {
            rigidbody.AddForce(Vector2.up * flying, ForceMode2D.Impulse);
        }

    }
}
