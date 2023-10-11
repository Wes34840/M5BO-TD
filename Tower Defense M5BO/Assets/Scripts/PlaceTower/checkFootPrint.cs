using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFootPrint : MonoBehaviour
{
    public List<GameObject> obj;

    private DraggableRangeIndicator range;

    private void Start()
    {
        range = transform.parent.GetComponentInChildren<DraggableRangeIndicator>();
    }
    internal bool isValid()
    {
        if (obj.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RangeColl") || collision.CompareTag("SelectBox"))
        {
            Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(), collision);
        }
        obj.Add(collision.gameObject);
        range.ChangeColor(isValid());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        obj.Remove(collision.gameObject);
        range.ChangeColor(isValid());
    }
}
