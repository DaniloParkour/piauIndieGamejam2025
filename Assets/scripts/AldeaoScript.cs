using UnityEngine;

public class AldeaoScript : MonoBehaviour
{

    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, 0.2f);
    }
}
