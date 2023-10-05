using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateEnemyHealthText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float maxHealth = GetComponentInParent<Slider>().maxValue;
        float currHealth = GetComponentInParent<Slider>().value;
        GetComponent<TMP_Text>().text = $"{currHealth}/{maxHealth}";
    }
}
