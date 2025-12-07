using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void OpenCreditsPanel()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
