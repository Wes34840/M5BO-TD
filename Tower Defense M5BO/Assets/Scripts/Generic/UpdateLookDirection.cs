using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class UpdateLookDirection : MonoBehaviour
{
    public void UpdateDirection(Vector3 target)
    {
        Vector3 newLookAt = target - transform.position;
        float Angle = Mathf.Atan2(newLookAt.y, newLookAt.x);
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Angle);
    }


}
