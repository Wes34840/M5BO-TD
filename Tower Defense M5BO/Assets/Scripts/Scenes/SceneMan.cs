using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{

    public void OnClick(string arg)
    {
        SceneManager.LoadScene(arg);
    }
}
