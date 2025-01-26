using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void OnMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnReplayClick()
    {
        SceneManager.LoadScene("GroﬂerPowerWalk");
    }
}
