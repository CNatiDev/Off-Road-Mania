using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnWh : MonoBehaviour
{
    #region
    public MSVehicleControllerFree engineT;
    public GameObject CanavasDisable;
    public Camera FrontCamera; 
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "finalCanavas")
        {
            CanavasDisable.SetActive(false);
            engineT.enabled = false;
           
        }
    }
}

