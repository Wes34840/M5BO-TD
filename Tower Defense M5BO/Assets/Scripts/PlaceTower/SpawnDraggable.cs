using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Draggables towerType;
    private DraggableSpawner draggableSpawner;
    private void Start()
    {
        draggableSpawner = GetComponentInParent<DraggableSpawner>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Deez Nuts");
        draggableSpawner.SpawnDraggable(towerType);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("drag end");
    }
}
