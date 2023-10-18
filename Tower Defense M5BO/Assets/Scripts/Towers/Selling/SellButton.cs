using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButton : MonoBehaviour
{
    public void OnClick()
    {
        GlobalData.selectedTower.GetComponent<SellScript>().SellTower();
    }
}
