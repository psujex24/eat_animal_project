using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{

    public Slider slider;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
