using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveButtonScript : MonoBehaviour
{

    private WaveHolder waveHolder;

    private void Start()
    {
        waveHolder = GameObject.Find("WaveHandler").GetComponent<WaveHolder>();
    }


    public void OnClick()
    {
        if (waveHolder.waveIsActive == false)
        {
            waveHolder.StartWave();
        }
    }


}
