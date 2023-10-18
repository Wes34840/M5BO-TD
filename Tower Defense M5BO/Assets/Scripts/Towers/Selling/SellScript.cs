using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellScript : MonoBehaviour
{
    internal void SellTower()
    {
        GlobalData.playerCash += Mathf.Round(GetComponent<TowerStats>().cost * 0.7f);
        GameObject.Find("TowerMenu").GetComponent<MenuControl>().CloseMenu();
        Destroy(gameObject);
    }
}
