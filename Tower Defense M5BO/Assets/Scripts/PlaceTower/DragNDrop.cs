using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    bool isDragging;
    [SerializeField] internal GameObject tower;

    void Start()
    {
        isDragging = true;
    }

    void Update()
    {
        DragAndDrop();
    }

    void DragAndDrop()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (isDragging)
        {
            transform.position = new Vector3(mousePosition.x, mousePosition.y, -1);
        }

        if (Input.GetMouseButtonUp(0))
        {
            PlaceTower();
        }
    }
    private void PlaceTower()
    {
        GlobalData.playerCash -= tower.transform.GetComponentInChildren<TowerStats>().cost;
        Instantiate(tower, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
