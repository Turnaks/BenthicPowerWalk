using UnityEngine;
using UnityEngine.SceneManagement;

public class Air : MonoBehaviour
{
    float CurrentAir = 0;
    [SerializeField]
    float MaxAir;

    [SerializeField]
    AirBar AirBar;

    private void Start()
    {
        CurrentAir = MaxAir;
        AirBar.SetMaxDisplay(MaxAir);
    }

    private void Update()
    {
        if (CurrentAir > 0)
            CurrentAir -= Time.deltaTime;
        else
        {
            CurrentAir = 0;
            SceneManager.LoadScene("GameOver");
        }

        AirBar.UpdateAir(CurrentAir);
    }

    public void LooseAir(float toLoose)
    {
        CurrentAir -= toLoose;
    }
}
