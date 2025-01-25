using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void OnContinueClick()
    {
        SceneManager.UnloadSceneAsync("PauseMenu");        
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
        //SceneManager.UnloadSceneAsync("IngameUI");
        //SceneManager.UnloadSceneAsync("PauseMenu");
    }
}
