using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFinal : MonoBehaviour
{
    public GameObject Canavas;
    public float time;
    public float time2;
    public GameObject Canavas2;
    public void StopCanavas()
    {
        Invoke("DisAble", time);
       
    }
    public void SartCanavas()
    {
      
        Invoke("DisAble1", time2);
    }


    void DisAble()
    {
        Canavas.SetActive(false);
    }
    void DisAble1()
    {
        Canavas2.SetActive(true);
    }
}
