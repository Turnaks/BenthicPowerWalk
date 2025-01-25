using UnityEngine;

public class Air : MonoBehaviour
{
    float CurrentAir = 0;
    [SerializeField]
    float MaxAir;

    public AirBar AirBar;

    private void Start()
    {
        CurrentAir = MaxAir;
        AirBar.DisplayMax=MaxAir;
    }

    private void Update()
    {
        if (CurrentAir >= 0)
            CurrentAir -= Time.deltaTime;
        else
            CurrentAir = 0;
        AirBar.UpdateAir(CurrentAir);
    }

    public void LooseAir(float toLoose)
    {
        CurrentAir -= toLoose;
    }
}
