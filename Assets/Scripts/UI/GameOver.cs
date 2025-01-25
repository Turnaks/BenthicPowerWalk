using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void OnRetryClick()
    {
        SceneManager.LoadScene("Gro�erPowerWalk");
    }

    public void OnMainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
