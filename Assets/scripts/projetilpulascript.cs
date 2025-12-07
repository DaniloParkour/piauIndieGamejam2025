using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float flying = 12f;
    private Rigidbody2D rigidbody;

    public float minX = -11f;
    public float maxX = 11f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.linearVelocityY < 0.01f && rigidbody.linearVelocityY > -0.01f)
        {
            rigidbody.AddForce(Vector2.up * flying, ForceMode2D.Impulse);
        }

    }
}
