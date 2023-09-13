using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoadWaveJSON : MonoBehaviour
{
    internal List<WaveStructure> LoadWave()
    {
        List<TextAsset> list = Resources.LoadAll<TextAsset>("WaveData").ToList(); // puts all text files in the assets/waveData folder into an array
        string json = list[0].text; // puts the first text files in folder
        Debug.Log(json); // prints the text of the first text file

        DataFile dataFile = JsonUtility.FromJson<DataFile>(json);
        return dataFile.data;
    }
}
