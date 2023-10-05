using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateProgSlider : MonoBehaviour
{
    Slider slider;
    public TowerUpgrader upgrader;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    internal void UpdateSlider(GameObject tower, int index)
    {
        upgrader = tower.transform.GetChild(4).GetComponent<UpgradePathHolder>().paths[index];
        slider.value = tower.transform.GetChild(4).GetComponent<UpgradePathHolder>().paths[index].tier;
    }
}
