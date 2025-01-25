using UnityEngine;

public class Air : MonoBehaviour
{
    public float CurrentAir = 0;
    public float MaxAir = 60;

    public AirBar AirBar;

    private void Start()
    {
        CurrentAir = MaxAir;
    }

    private void Update()
    {
        if (CurrentAir >= 0)
            CurrentAir -= Time.deltaTime;
        else
            CurrentAir = 0;
        AirBar.UpdateAir(CurrentAir);
    }


}
