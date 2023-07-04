using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke_Wh_bk : MonoBehaviour
{
    public GameObject senzWater;
    public Speedometer senz;
    public ParticleSystem[] smoke;
    public ParticleSystem[] water;
    public ParticleSystem splash;
    float i = 1f;
    private void Start()
    {
        Invoke("stopParticle", 0.1f);
    }
    void stopParticle()
    {
        for (int j = 0; j < 4; j++)
        {
            smoke[j].Stop();
            water[j].Stop();
            splash.Stop();
        }
    }
    void Update()
    {

        if (senz.speed > i)
        {           
            for (int j = 0; j < 4; j++)
                smoke[j].Play();
        }
        /*else
        {
            for (int j = 0; j < 4; j++)
               water[j].Stop();
        }*/
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tr")
        {

            for (int j = 0; j < 4; j++)
            { 
                smoke[j].enableEmission = false;              
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "water")
        {
            for (int j = 0; j < 4; j++)
            {
                water[j].Play();
            }
        }
        else
        if (other.gameObject.tag == "watersplash")
        {
            splash.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        for (int j = 0; j < 4; j++)
        {          
            water[j].Stop();
        }
    }
    
}
