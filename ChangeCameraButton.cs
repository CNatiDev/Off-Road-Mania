using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraButton : MonoBehaviour
{ public LoadCharacter Camera4;
    public Camera[] Cameras;
    int i = 0;
   
    public void ChangeCamera()
    {
        Cameras[2] = Camera4.clona.GetComponent<EnWh>().FrontCamera;
        i++;
        if (i > 2)
        {
            i = 0;
            Cameras[i].enabled = true;
        }
        else
        {
        Cameras[i - 1].enabled = false;
        Cameras[i].enabled = true; 
        }
   }

}
