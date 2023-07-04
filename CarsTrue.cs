using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsTrue : MonoBehaviour
{
   
    public cameraFal camera1;
    public LoadCharacter cloneCars;

  
    void Start()
    {
        Invoke("LaunchProjectile", 0.1f);
        camera1.target = cloneCars.clona;
    }

    void LaunchProjectile()
    { 
        //cloneCars.clona.transform.eulerAngles = new Vector3(0f, 0f, 0f);
         cloneCars.clona.transform.eulerAngles = cloneCars.spawnPoint.eulerAngles;
        cloneCars.clona.transform.localScale = cloneCars.spawnPoint.transform.localScale;

    }
    IEnumerator ExecuteAfterTime1(float time)
    {

        yield return new WaitForSeconds(time);
        { 
        camera1.target = cloneCars.clona;

        }
    }
    
    void Update()
    {

        StartCoroutine(ExecuteAfterTime1(0.1f));
   
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag  == "final")
        {
            Debug.Log("lovit +++++++++++++++");
        }
    }
}
