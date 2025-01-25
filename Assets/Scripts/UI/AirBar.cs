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
    }

    public void UpdateAir(float air)
    {
        AirBarSlider.value = air;
    }

    public void SetMaxDisplay(float value)
    {
        AirBarSlider.maxValue = value;
        AirBarSlider.value = value;
    }
}
