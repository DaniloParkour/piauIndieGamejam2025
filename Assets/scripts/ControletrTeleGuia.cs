using UnityEngine;

public class ControletrTeleGuia : MonoBehaviour
{

    public Transform player;
    //private Transform target;
    private Vector3 snowDirection;
    public float snowSpeed = 5f;
    
    //public float minX = -11f;
   // public float maxX = 11f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //private void Awake()
    //{
       // float offset = Camera.main.gameObject.transform.position.x;
       // float novoX = offset + Random.Range(minX, maxX);
       // transform.position = new Vector3(novoX, transform.position.y, transform.position.z);
 //   }
    void Start()
    {
        //target.position = Vector3.(player.position, player.position, player.position);
        
        snowDirection = player.position - transform.position;
        snowDirection = snowDirection.normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(snowDirection * snowSpeed); 
        //= Vector3.Lerp(target.position, target.position, 0.2f);
    }
}

