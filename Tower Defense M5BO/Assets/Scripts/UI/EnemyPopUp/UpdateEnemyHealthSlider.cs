using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateEnemyHealthSlider : MonoBehaviour
{
    private Slider slider;
    internal EnemyStats stats;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats != null)
        {
            slider.value = stats.health;
            slider.maxValue = stats.maxHealth;
        }
    }
}
