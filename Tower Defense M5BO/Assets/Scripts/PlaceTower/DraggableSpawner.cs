using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    internal void SpawnDraggable(Draggables type)
    {
        if (GetComponent<DragDropDatabase>().towers[(int)type].transform.GetComponentInChildren<TowerStats>().cost > GlobalData.playerCash) // check if player can afford the tower
        {
            return;
        }
        GameObject draggable = Instantiate(prefab, transform.position, Quaternion.identity);
        draggable.GetComponent<SpriteRenderer>().sprite = GetComponent<DragDropDatabase>().sprites[(int)type];
        draggable.GetComponent<DragNDrop>().tower = GetComponent<DragDropDatabase>().towers[(int)type];
    }
}
