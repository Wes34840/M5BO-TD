using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUpgrade : MonoBehaviour
{
    
    public DisplayTowerMenu display;
    public void onClick(int path)
    {
        GlobalData.selectedTower.GetComponentInChildren<UpgradePathHolder>().ApplyUpgradeFromPath(path);
        display.UpdateDisplay();
    }

}
