using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleAutoStart : MonoBehaviour
{
    [SerializeField] TMP_Text textField;
    public void OnClick()
    {
        switch (GlobalData.autoStart)
        {
            case true:
                GlobalData.autoStart = false;
                textField.text = "Auto Start = Off";
                break;
            case false:
                GlobalData.autoStart = true;
                textField.text = "Auto Start = On";
                break;
        }
    }
}
