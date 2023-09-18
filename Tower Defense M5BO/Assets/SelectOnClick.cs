using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOnClick : MonoBehaviour
{
    [SerializeField] private GameObject selectionSquare;
    private BoxCollider2D hitBox;

    void Start()
    {
        hitBox = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (hitBox == Physics2D.OverlapPoint(mousePosition) && GlobalData.selectedTower != gameObject)
            {
                SelectTower();
            }
            else if (GlobalData.selectedTower == gameObject)
            {
                DeselectTower();
            }
        }
    }

    private void SelectTower()
    {
        GlobalData.selectedTower = gameObject;
        selectionSquare.SetActive(true);
    }

    internal void DeselectTower()
    {
        GlobalData.selectedTower = null;
        selectionSquare.SetActive(false);
    }
}
