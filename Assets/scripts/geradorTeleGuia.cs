using UnityEngine;

public class geradorTeleGuia : MonoBehaviour
{
    public float tempoMin = 5;
    public float tempoMax = 10;
    public GameObject prefabNeve;
    private float tempoCriarNovaNeve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tempoCriarNovaNeve <= 0)
        {

            Instantiate(prefabNeve);
            tempoCriarNovaNeve = Random.Range(tempoMin, tempoMax);
        }
        else
        {
            tempoCriarNovaNeve -= Time.deltaTime;
        }



    }
}
