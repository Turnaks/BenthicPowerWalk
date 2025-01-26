using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
            return;

        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
