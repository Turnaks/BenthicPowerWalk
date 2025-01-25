using UnityEngine;
using UnityEngine.UI;

public class AirBar : MonoBehaviour
{
    public Slider AirBarSlider;
    public Air PlayerAir;    

    private void Start()
    {
        PlayerAir = GameObject.FindGameObjectWithTag("Player").GetComponent<Air>();
        AirBarSlider = GetComponent<Slider>();

        AirBarSlider.maxValue = PlayerAir.MaxAir;
        AirBarSlider.value = PlayerAir.CurrentAir;
    }

    public void UpdateAir(float air)
    {
        AirBarSlider.value = air;
    }
}
