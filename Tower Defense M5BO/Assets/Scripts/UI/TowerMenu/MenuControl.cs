using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public Animator menuAnim, lifeCashAnim;
    private DisplayTowerMenu display;
    private void Start()
    {
        display = GetComponent<DisplayTowerMenu>();
    }
    public void OpenMenu()
    {
        menuAnim.SetBool("isOpen", true);
        lifeCashAnim.SetBool("isOpen", true);
        display.UpdateDisplay();
    }

    public void CloseMenu()
    {
        menuAnim.SetBool("isOpen", false);
        lifeCashAnim.SetBool("isOpen", false);
    }

}
