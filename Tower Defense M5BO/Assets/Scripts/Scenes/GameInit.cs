using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    void Start()
    {
        GlobalData.playerCash = 100000;
        GlobalData.playerHealth = 100f;
        GlobalData.gameIsActive = true;
        GlobalData.menuIsOpen = false;
        GlobalData.selectedEnemy = null;
        GlobalData.selectedTower = null;
    }
}
