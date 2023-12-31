using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableRangeIndicator : MonoBehaviour
{
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    internal void ChangeColor(bool isValid)
    {
        switch (isValid)
        {
            case true:
                sprite.color = new Color(0, 0, 0, 0.3f);
                break;
            case false:
                sprite.color = new Color(0.8f, 0, 0, 0.3f); 
                break;
        }
    }

}
