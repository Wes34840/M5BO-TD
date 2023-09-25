using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTowerMenu : MonoBehaviour
{
    public Image menuSprite;

    void Update()
    {
        if (GlobalData.selectedTower == null)
        {
            return;
        }
        menuSprite.sprite = GlobalData.selectedTower.transform.parent.GetChild(3).GetComponent<SpriteRenderer>().sprite;

    }
}
