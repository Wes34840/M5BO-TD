using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class ShowEnemyHealth : MonoBehaviour
{
    private EnemyPopUpScript enemyPopUp;
    [SerializeField] private BoxCollider2D coll;

    private void Start()
    {
        enemyPopUp = GameObject.Find("EnemyPanel").GetComponent<EnemyPopUpScript>();
        coll = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (coll == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
        {
            GlobalData.selectedEnemy = gameObject;
            enemyPopUp.OpenPopup(transform.parent);
        }
        else if (GlobalData.selectedEnemy == gameObject)
        {
            ClosePopup();
        }
    }

    internal void ClosePopup()
    {
        enemyPopUp.ClosePopup();
    }

}
