using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class DraggableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    internal void SpawnDraggable(Draggables type)
    {
        GameObject tower = GetComponent<DragDropDatabase>().towers[(int)type];
        
        if (tower.transform.GetComponentInChildren<TowerStats>().cost > GlobalData.playerCash) // check if player can afford the tower
        {
            return;
        }
        GameObject draggable = Instantiate(prefab, transform.position, Quaternion.identity);

        ApplyTowerToDraggable(draggable, tower);

    }

    private void ApplyTowerToDraggable(GameObject drag, GameObject tower)
    {
        TowerStats stats = tower.GetComponent<TowerStats>();

        SpriteRenderer dragSprite = drag.transform.GetChild(2).GetComponent<SpriteRenderer>();
        dragSprite.sprite = tower.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;

        dragSprite.transform.localScale = tower.transform.GetChild(3).localScale;
        drag.transform.GetChild(0).localScale = tower.transform.GetChild(0).localScale;
        drag.transform.GetChild(1).transform.localScale = new Vector3(stats.range, stats.range, 1);

        drag.GetComponent<DragNDrop>().tower = tower;
    }
}
