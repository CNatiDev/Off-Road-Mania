using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public LoadCharacter Clona;
    public Vector3 Ofsset;
  

    void Update()
    {
        transform.position = Clona.clona.transform.position + Ofsset;
        Vector3 rot = new Vector3(90, Clona.clona.transform.eulerAngles.y, 0);
        transform.rotation = Quaternion.Euler(rot);
    }
}
