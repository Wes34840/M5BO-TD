using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAudioSource : MonoBehaviour
{
    public GameObject source;
    public AudioClip clip;
    internal void SpawnAudio()
    {
        GameObject src = Instantiate(source, transform.position, Quaternion.identity);
        src.GetComponent<AudioSource>().PlayOneShot(clip);
    }

    // real fuckin lazy, I know
}
