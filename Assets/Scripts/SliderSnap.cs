using UnityEngine;
using UnityEngine.UI;

public class SliderSnap : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        // Add a listener to the slider's value changed event
        slider.onValueChanged.AddListener(delegate { SnapValue(); });
    }

    void SnapValue()
    {
        // Calculate the closest snap value
        slider.value = Mathf.Round(slider.value * 10f) / 10f;
    }
}

