using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FastForwardButton : MonoBehaviour
{
    internal TMP_Text textField;
    internal bool isActive;

    private void Start()
    {
        textField = GetComponentInChildren<TMP_Text>();
    }

    public void OnClick()
    {
        switch (isActive)
        {
            case false:
                EnableFF();
                break;
            case true:
                DisableFF();
                break;
        }
    }

    public void EnableFF()
    {
        textField.fontStyle = FontStyles.Bold;
        textField.text = $">>>";
        Time.timeScale = 2.0f;
        isActive = true;
        Debug.Log("EnabledFF");
    }

    public void DisableFF()
    {
        textField.fontStyle = FontStyles.Normal;
        textField.text = $">";
        Time.timeScale = 1.0f;
        isActive = false;
        Debug.Log("DisabledFF");
    }
}
