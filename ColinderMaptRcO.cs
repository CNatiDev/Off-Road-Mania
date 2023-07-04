using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColinderMaptRcO : MonoBehaviour
{
    public ReSpaunInXpoint reSpaun;
    public bool MapReverse = true;
    void choose()
    {
        if (MapReverse == true)
            reSpaun.respawn();
        else
            reSpaun.respawn2();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tr")
        {
            choose();
          //  Debug.LogWarning("MapHit");
          //  Debug.Log("Nume: " + other.name);
            reSpaun.Egaleaza();
        }
    }

}
