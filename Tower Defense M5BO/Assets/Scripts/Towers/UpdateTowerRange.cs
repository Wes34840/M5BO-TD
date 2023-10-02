using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTowerRange : MonoBehaviour
{
    private TowerStats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = transform.parent.GetComponent<TowerStats>();
        UpdateRange();
    }

    internal void UpdateRange()
    {
        gameObject.transform.localScale = new Vector3(stats.range, stats.range, 1);
    }

}
