using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{
    public Transform Transform;
    public int n;

   
    public void setRot()
    {
        Transform.eulerAngles = new Vector3(0f, 0f, 0f);

       
    }
}
