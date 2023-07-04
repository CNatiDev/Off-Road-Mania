using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{

    public GameObject   navigator;
    public LoadCharacter clona;


    // Update is called once per frame
    void Update()
    {
        navigator.transform.position = new Vector3(clona.clona.transform.position.x, clona.clona.transform.position.y + 10f, clona.clona.transform.position.z);
        /*navigator.transform.eulerAngles = new Vector3(90, 0, clona.clona.transform.rotation.z);
        var Rotation = clona.clona.transform.rotation.z;
        navigator.transform.Rotate(navigator.transform.rotation.x, navigator.transform.rotation.y, Rotation);*/
      

    }
 
}
