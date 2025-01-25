using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void OnEnable()
    {
        Time.timeScale = 0.0f;
    }

    public void OnDisable()
    {
        Time.timeScale = 1.0f;
    }

    public void OnContinueClick()
    {
        gameObject.SetActive(false);
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
        //SceneManager.UnloadSceneAsync("IngameUI");
        //SceneManager.UnloadSceneAsync("PauseMenu");
    }
}
