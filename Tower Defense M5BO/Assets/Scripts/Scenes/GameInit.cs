using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    void Start()
    {
        GlobalData.playerCash = 200000f;
        GlobalData.playerHealth = 200f;
        GlobalData.gameIsActive = true;
        GlobalData.menuIsOpen = false;
        GlobalData.selectedEnemy = null;
        GlobalData.selectedTower = null;
    }
}
