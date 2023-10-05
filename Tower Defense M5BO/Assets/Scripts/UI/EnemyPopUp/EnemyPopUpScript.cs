using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPopUpScript : MonoBehaviour
{
    EnemyStats enemyStats;
    [SerializeField] private UpdateEnemyHealthSlider sliderUpdate;
    [SerializeField] private UpdateEnemyNameText textUpdate;
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }

    internal void OpenPopup(Transform enemy)
    {
        enemyStats = enemy.GetComponent<EnemyStats>();
        GetComponent<CanvasGroup>().alpha = 1f;
        sliderUpdate.stats = enemyStats;
        textUpdate.UpdateText(enemyStats.enemyName);
    }

    internal void ClosePopup()
    {
        GetComponent<CanvasGroup>().alpha = 0f;
    }
}
