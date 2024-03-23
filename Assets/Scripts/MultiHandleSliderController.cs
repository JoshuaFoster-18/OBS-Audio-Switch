using UnityEngine;
using UnityEngine.UI;

public class MultiHandleSliderController : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    void Start()
    {
        // Initial setup or constraints can be added here
    }

    public void AdjustSliders()
    {
        // Prevent slider2 from going below slider1 or above slider3
        slider2.minValue = slider1.value;
        slider2.maxValue = slider3.value;

        // Adjust slider1 and slider3 limits based on slider2's position if needed
        // For example, preventing slider1 from exceeding slider2's value
        slider1.maxValue = slider2.value;
        slider3.minValue = slider2.value;
    }
}
