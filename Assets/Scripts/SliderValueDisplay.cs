using UnityEngine;
using UnityEngine.UI;

public class SliderValueDisplay : MonoBehaviour
{
    public Slider slider; // Reference to your slider
    public Text valueText; // Reference to your text element

    void Start()
    {
        // Optional: Add a listener to update the text only when the slider value changes
        slider.onValueChanged.AddListener(delegate { UpdateValueDisplay(); });
        UpdateValueDisplay(); // Update display on start
    }

    void UpdateValueDisplay()
    {
        // Update the text to display the slider's value
        valueText.text = slider.value.ToString("0.#"); // Formats the value to two decimal places
    }
}


