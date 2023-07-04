using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMap : MonoBehaviour
{
    public GameObject ColinderMap1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tr")
        {
            ColinderMap1.SetActive(false);
        }
    }
}
