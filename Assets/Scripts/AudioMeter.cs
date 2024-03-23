using UnityEngine;
using UnityEngine.UI;

public class AudioMeter : MonoBehaviour
{
    public Image audioMeterImage; // Assign this in the inspector

    void Start(){
        UpdateMeter(1f);
    }

    public void UpdateMeter(float audioLevel)
    {
        // Assume audioLevel is a value between 0 and 1
        audioMeterImage.fillAmount = audioLevel;
    }
}

