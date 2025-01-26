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

    public void Update()
    {
        ManageAir();
        AirBar.UpdateAir(CurrentAir);
    }

    private void ManageAir()
    {
        if (_isInvincible)
        {
            CurrentAir = MaxAir;
            return;
        }

        if (CurrentAir > 0)
        {
            CurrentAir -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void GainAir(float airGain)
    {
        CurrentAir += airGain;
        if (CurrentAir > MaxAir)
            CurrentAir = MaxAir;
    }
    public void LooseAir(float airLoss)
    {
        CurrentAir -= airLoss;
    }
}
