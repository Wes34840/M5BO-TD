using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceedMenu : MonoBehaviour
{
    public GameObject currPanel, nextPanel;
    public void Proceed()
    {
        currPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

}
