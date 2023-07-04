using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespwnPoint : MonoBehaviour
{   
    public   int pozitie=-1;
    [HideInInspector]
    public int pozitia2 = 0;
    public int pozitia3 = 0;
    public int pozitia4 = 0;
    public GameObject Colinder;
    public ReSpaunInXpoint respawnControlerr;
   public ParticleSystem[] fire;
    public bool MapReverse = true;
    private void Start()
    { pozitia4 = fire.Length;
        respawnControlerr.Egaleaza();

    }
    private void OnTriggerEnter(Collider Vehicul)
    {
        if (Vehicul.gameObject.tag == "Respawn")
        {
           
            pozitie += 1;
            pozitia3 += 1;
            Colinder.SetActive(true);
            Vehicul.gameObject.SetActive(false);
            respawnControlerr.Egaleaza();
            pozitia4 -= 2;
            if (MapReverse == true)

            {
                fire[pozitia2].enableEmission = true;
                fire[pozitia2 + 1].enableEmission = true;
            }

            else

            {
                fire[pozitia4].enableEmission = true;
                fire[pozitia4 + 1].enableEmission = true;
            }
            pozitia2 += 2;

           // Debug.Log("Nume: " + Vehicul.name +" "+ Vehicul.tag);
        }
    }
    
    
}
