using UnityEngine;
using UnityEngine.UI;

public class CascoUI : MonoBehaviour
{

    public Sprite[] cascoImages;
    public PlayerMoviments player;

    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.contadorImortal > 0)
        {
            image.sprite = cascoImages[6 - (int)player.contadorImortal];
        } else
        {
            image.sprite = cascoImages[0];
        }
    }
}
