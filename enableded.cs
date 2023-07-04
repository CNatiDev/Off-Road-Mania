using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableded : MonoBehaviour
{
    public Transform transform;
     void  Update ()
    {
        if (transform.rotation.z > 165 || transform.rotation.y > 165|| transform.rotation.x > 165|| transform.rotation.z < -165 || transform.rotation.y < -165 || transform.rotation.x < -165)
            Debug.LogWarning("rsturnayt");
    }
    public void frana()
    {
        Input.GetKey("x");
        Debug.Log("fran");
    }
}
