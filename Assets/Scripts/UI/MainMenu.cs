using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
    public void OnPlayClick()
    {
        SceneManager.LoadScene("GroﬂerPowerWalk");
        //SceneManager.UnloadSceneAsync("MainMenu");
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }
}
