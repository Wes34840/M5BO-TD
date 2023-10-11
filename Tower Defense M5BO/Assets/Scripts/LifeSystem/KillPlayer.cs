using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{ 
    internal void Defeat()
    {
        GetComponent<Animator>().SetBool("PlayerIsDead", true);
    }
}
