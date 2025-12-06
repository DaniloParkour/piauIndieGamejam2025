using UnityEngine;

public class projetilscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rigidbody;
    public float minX = -11f ;
    public float maxX = 11f ;

    void Start()
    {
        float offset = Camera.main.gameObject.transform.position.x;
        float novoX = offset + Random.Range(minX, maxX);
        transform.position = new Vector3(novoX, transform.position.y, transform.position.z);
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(0f, -0.011f);
    }


    // Update is called once per frame
    void Update()
    {

        if (rigidbody.linearVelocityY > -0.01 && rigidbody.linearVelocityY < 0.01) { 
            Destroy(this.gameObject);
        }
    }
}
