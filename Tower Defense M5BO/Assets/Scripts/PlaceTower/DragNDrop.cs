using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    bool isDragging;
    [SerializeField] internal GameObject tower;
    private checkFootPrint check;

    void Start()
    {
        check = GetComponentInChildren<checkFootPrint>();
        GlobalData.isPlacing = true;
    }

    void Update()
    {
        DragAndDrop();
    }

    void DragAndDrop()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, -1);

        if (Input.GetMouseButtonUp(0) && check.isValid())
        {
            PlaceTower();
        }
    }
    private void PlaceTower()
    {
        GlobalData.playerCash -= tower.transform.GetComponentInChildren<TowerStats>().cost;
        Instantiate(tower, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GlobalData.isPlacing = false;
    }
}
