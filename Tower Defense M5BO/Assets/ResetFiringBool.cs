using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFiringBool : MonoBehaviour
{
    public void EndFiring()
    {
        GetComponent<Animator>().SetBool("isFiring", false);
    }
}
