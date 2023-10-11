using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    internal void SpawnDraggable(Draggables type)
    {
        GameObject tower = GetComponent<DragDropDatabase>().towers[(int)type];
        TowerStats stats = tower.GetComponent<TowerStats>();
        
        if (tower.transform.GetComponentInChildren<TowerStats>().cost > GlobalData.playerCash) // check if player can afford the tower
        {
            return;
        }
        GameObject draggable = Instantiate(prefab, transform.position, Quaternion.identity);
        draggable.GetComponent<SpriteRenderer>().sprite = tower.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
        draggable.GetComponent<DragNDrop>().tower = tower;
        draggable.transform.GetChild(1).transform.localScale = new Vector3(stats.range, stats.range, 1);
    }
}
