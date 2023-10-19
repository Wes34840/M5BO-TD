using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFFButton : MonoBehaviour
{
    internal bool keepActiveBool;
    [SerializeField] private GameObject FFButton, NextWave;
    private FastForwardButton toggleFF;
    private void Start()
    {
        toggleFF = FFButton.GetComponent<FastForwardButton>();
    }
    internal void ToggleOn()
    {
        FFButton.SetActive(true);
        if (keepActiveBool) toggleFF.EnableFF();
        NextWave.SetActive(false);
    }
    internal void ToggleOff()
    {
        keepActiveBool = toggleFF.isActive;
        toggleFF.DisableFF();
        FFButton.SetActive(false);
        NextWave.SetActive(true);
    }
}
