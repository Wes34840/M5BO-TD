using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrader : MonoBehaviour
{
    internal int tier = 0;
    private TowerStats stats;
    [SerializeField] internal bool canUpgrade = true;
    [SerializeField] private TowerUpgrader opPath;

    [SerializeField] private List<Upgrade> upgrades;
    void Start()
    {
        stats = transform.parent.parent.GetComponent<TowerStats>(); // this is gonna end up being a fucking tunnel
    }

    internal void InitUpgrade()
    {
        if (canUpgrade && GlobalData.playerCash >= upgrades[tier].cost)
        {
            GlobalData.playerCash -= upgrades[tier].cost;
            Upgrade();
        }
        StartCoroutine(IfSpam());
    }

    private void Upgrade()
    {
        if (upgrades[tier].sprite != null)
        {
            ApplySprite(upgrades[tier].sprite);
        }

        ApplyStats(upgrades[tier].stats);

        if (upgrades[tier].projectile != null)
        {
            ApplyProjectile(upgrades[tier].projectile);
        }

        tier++;

        transform.parent.parent.GetComponentInChildren<UpdateTowerRange>().UpdateRange();
    }

    private void ApplySprite(Sprite sprite)
    {
        transform.parent.parent.GetChild(3).GetComponent<SpriteRenderer>().sprite = sprite;
    }
    
    private void ApplyStats(float[] newStats)
    {
        stats.range += newStats[(int)StatEnum.range];
        stats.firingSpeed += newStats[(int)StatEnum.firingSpeed];
        stats.projectileDamage += newStats[(int)StatEnum.projDamage];
        stats.projectilePierce += newStats[(int)StatEnum.projPierce];
        stats.projectileSpeed += newStats[(int)StatEnum.projSpeed];
    }

    private void ApplyProjectile(GameObject proj)
    {
        GetComponentInParent<ShootProjectile>().projectile = proj;
    }

    internal float GetUpgradeCost(int disTier)
    {
        return upgrades[disTier].cost;
    }

    internal string GetTitle(int disTier)
    {
        return upgrades[disTier].title;
    }

    internal string GetDescription(int disTier)
    {
        return upgrades[disTier].description;
    }

    private IEnumerator IfSpam()
    {
        yield return new WaitForEndOfFrame();
        // can't think of a better way to implement atm
        if (tier >= 2 && opPath.tier == 1)
        {
            opPath.canUpgrade = false;
        }
        if (tier == 1 && opPath.tier >= 2)
        {
            canUpgrade = false;
        }
        if (tier == 3)
        {
            canUpgrade = false;
        }
    }
}
