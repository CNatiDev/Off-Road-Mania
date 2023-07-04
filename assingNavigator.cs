using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assingNavigator : MonoBehaviour
{
    public GameObject camera;
    public LoadCharacter claona;


 
    void Update()
    {
        camera.transform.position = new Vector3(claona.clona.transform.position.x, camera.transform.position.y, claona.clona.transform.position.z);
    }
    
}
