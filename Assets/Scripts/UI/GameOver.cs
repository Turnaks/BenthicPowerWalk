using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void OnRetryClick()
    {
        SceneManager.LoadScene("GroﬂerPowerWalk");
    }

    public void OnMainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
