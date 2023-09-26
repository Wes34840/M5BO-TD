using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SelectOnClick : MonoBehaviour
{
    [SerializeField] private GameObject selectionSquare;
    private BoxCollider2D hitBox;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private MenuControl menuControl;
    [SerializeField] private float menuColl;

    void Start()
    {
        hitBox = GetComponent<BoxCollider2D>();
        menuControl = GameObject.Find("TowerMenu").GetComponent<MenuControl>();
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = Camera.main.orthographicSize/2;

        menuColl = worldHeight * aspect * -1;
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (GlobalData.selectedTower != null && mousePosition.x < menuColl)
            {
                return;
            }
            else if (hitBox == Physics2D.OverlapPoint(mousePosition) && GlobalData.selectedTower != gameObject)
            {
                SelectTower();
                return;
            }
            else
            {
                DeselectTower();
            }
        }

    }

    private void SelectTower()
    {
        GlobalData.selectedTower = gameObject;
        selectionSquare.SetActive(true);
        Color tmp = spriteRenderer.color;
        tmp.a = 0.4f;
        spriteRenderer.color = tmp; // make range visible
        menuControl.OpenMenu();
    }

    internal void DeselectTower()
    {
        selectionSquare.SetActive(false);
        Color tmp = spriteRenderer.color;
        tmp.a = 0;
        spriteRenderer.color = tmp; // make range invisible
        StartCoroutine(EndOfFrame());

    }
    private IEnumerator EndOfFrame()
    {
        yield return new WaitForEndOfFrame();

        if (GlobalData.selectedTower ==  gameObject)
        {
            GlobalData.selectedTower = null;
            menuControl.CloseMenu();
        }
    }
}
