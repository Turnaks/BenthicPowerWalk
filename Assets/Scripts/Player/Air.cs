using UnityEngine;
using UnityEngine.SceneManagement;

public class Air : MonoBehaviour
{
    float CurrentAir = 0;
    [SerializeField]
    float MaxAir;

    [SerializeField]
    AirBar AirBar;

    [SerializeField]
    private bool _isInvincible = false;

    private void Start()
    {
        CurrentAir = MaxAir;
        AirBar.SetMaxDisplay(MaxAir);
    }

    private void Update()
    {
        if (CurrentAir > 0)
            CurrentAir -= Time.deltaTime;
        else if(!_isInvincible)
        {
            SceneManager.LoadScene("GameOver");
        }

        AirBar.UpdateAir(CurrentAir);
    }

    public void ChangeAir(float change)
    {
        CurrentAir += change;
    }
}
