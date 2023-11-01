using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsControl : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void OpenMenu()
    {
        anim.SetBool("isOpen", true);
        GlobalData.optionsIsOpen = true;
    }
    public void CloseMenu()
    {
        anim.SetBool("isOpen", false);
        GlobalData.optionsIsOpen = false;
    }
}
