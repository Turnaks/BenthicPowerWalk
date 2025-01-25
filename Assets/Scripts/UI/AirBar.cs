using UnityEngine;
using UnityEngine.UI;

public class AirBar : MonoBehaviour
{
    public Slider AirBarSlider;
    public Air PlayerAir;
    public float DisplayMax;

    private void Start()
    {
        PlayerAir = GameObject.FindGameObjectWithTag("Player").GetComponent<Air>();
        AirBarSlider = GetComponent<Slider>();

        AirBarSlider.maxValue = DisplayMax;
        AirBarSlider.value = DisplayMax;
    }

    public void UpdateAir(float air)
    {
        AirBarSlider.value = air;
    }
}
