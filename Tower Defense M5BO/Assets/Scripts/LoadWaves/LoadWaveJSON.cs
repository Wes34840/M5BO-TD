using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoadWaveJSON : MonoBehaviour
{

    void Start()
    { 
        
    }

    internal void LoadWave(int wave)
    {
        List<TextAsset> list = Resources.LoadAll<TextAsset>("waveData").ToList(); // puts all text files in the assets/waveData folder
        string json = list[wave].text; // puts the first text files in text
        Debug.Log(json); // prints the text of the first text file
    }
}