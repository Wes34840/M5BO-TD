using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public Animator menuAnim, lifeCashAnim;
    public void OpenMenu()
    {
        menuAnim.SetBool("isOpen", true);
        lifeCashAnim.SetBool("isOpen", true);
    }

    public void CloseMenu()
    {
        menuAnim.SetBool("isOpen", false);
        lifeCashAnim.SetBool("isOpen", false);
    }

}
