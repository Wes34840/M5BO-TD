using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTowerMenu : MonoBehaviour
{
    public Image menuSprite;
    public GameObject[] pathDisplays;
    [SerializeField] private Animator towerAnim;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (GlobalData.selectedTower != null )
        {
            Animator anim = GlobalData.selectedTower.transform.GetChild(3).GetComponent<Animator>();
            if (anim != null && !anim.GetBool("isFiring"))
            { 
                menuSprite.sprite = GlobalData.selectedTower.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
            }
        }
    }

    internal void UpdateDisplay()
    {
        GameObject tower = GlobalData.selectedTower;
        menuSprite.sprite = tower.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
        StartCoroutine(DisplayAll(tower));
    }

    private IEnumerator DisplayAll(GameObject tower)
    {
        yield return new WaitForEndOfFrame();
        UpdateButtons(tower);
        UpdateTextFields(tower);
        UpdateSliders(tower);
    }

    private void UpdateButtons(GameObject tower)
    {
        UpgradePathHolder upgradeHolder = tower.GetComponentInChildren<UpgradePathHolder>();
        for (int i = 0; i < upgradeHolder.paths.Length; i++)
        {
            int tier = upgradeHolder.paths[i].tier;
            if (upgradeHolder.paths[i].canUpgrade == false)
            {
                pathDisplays[i].gameObject.transform.GetChild(2).GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f);
            }
            else
            {
                pathDisplays[i].gameObject.transform.GetChild(2).GetComponent<Image>().color = new Color(1, 1, 1);
            }
            if (upgradeHolder.paths[i].tier == 3)
            {
                tier--;
            }
            
            pathDisplays[i].transform.GetChild(2).GetComponentInChildren<TMP_Text>().text = $"${upgradeHolder.paths[i].GetUpgradeCost(tier)}";
        }
    }

    private void UpdateTextFields(GameObject tower)
    {
        for (int i = 0; i < pathDisplays.Length; i++)
        {
            int tier = tower.GetComponentInChildren<UpgradePathHolder>().paths[i].tier;

            if (tier == 3) tier--;

            pathDisplays[i].transform.GetChild(0).GetComponent<UpdateUpgradeTitle>().UpdateTitle(tower, i, tier);
            pathDisplays[i].transform.GetChild(1).GetComponent<UpdateUpgradeDescription>().UpdateDescription(tower, i, tier);
        }
    }


    private void UpdateSliders(GameObject tower)
    {
        for (int i = 0; i < pathDisplays.Length; i++ )
        {
            pathDisplays[i].transform.GetComponentInChildren<UpdateProgSlider>().UpdateSlider(tower, i);

        }
    }
}
