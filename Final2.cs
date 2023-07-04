using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final2 : MonoBehaviour
{
    public GameObject Panel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="tr")
        {
            Panel.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
