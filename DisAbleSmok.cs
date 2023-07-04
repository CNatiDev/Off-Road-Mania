using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisAbleSmok : MonoBehaviour
{
    [HideInInspector]
   
    public GameObject car;
    public ParticleSystem[] water;
    public MSVehicleControllerFree vehicaMouvement;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "water")
        {
            Debug.Log("Water");
        }
 
    }
}

