using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] GameObject DeathScreen, VictoryScreen;

    internal void Defeat()
    {
        GlobalData.gameIsActive = false;
        DeathScreen.GetComponent<Animator>().SetBool("TriggerEvent", true);
    }
    internal void Victory()
    {
        GlobalData.gameIsActive = false;
        VictoryScreen.GetComponent<Animator>().SetBool("TriggerEvent", true);
    }
}
