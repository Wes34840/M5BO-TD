using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateWaveCounter : MonoBehaviour
{
    TMP_Text textField;
    WaveHolder waveHolder;

    void Start()
    {
        textField = GetComponent<TMP_Text>();
        waveHolder = GameObject.Find("WaveHandler").GetComponent<WaveHolder>();
    }

    void Update()
    {
        textField.text = $"Wave: {waveHolder.waveIndex}";
    }
}
