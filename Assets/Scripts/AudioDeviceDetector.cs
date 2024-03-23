using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioDeviceDetector : MonoBehaviour
{
    public Dropdown deviceDropdown;

    void Start()
    {
        PopulateAudioDeviceDropdown();
    }

    void PopulateAudioDeviceDropdown()
    {
        List<string> options = new List<string>();

        foreach (var device in Microphone.devices)
        {
            options.Add(device);
        }

        deviceDropdown.ClearOptions();
        deviceDropdown.AddOptions(options);
    }
}

