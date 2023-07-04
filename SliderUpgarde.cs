using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpgarde : MonoBehaviour
{
    public Slider[] slider;
    public MSVehicleControllerFree[] Engine;
    public SaveLoadCarSelected save;
    public AsignUpgrade asign;
    int current;
    float Et;
    float SvVal1;


    private void Start()
    {
        Invoke("egaleaz", 0.1f);
        egalValue();
        LoadSlider();
        
        LoadCharacterSelected();
        

    }
   

    //Creste valoarea slider-ului
    public void upgrade()
    {
        Engine[0]._vehicleTorque.engineTorque +=1.5f;
        //PlayerPrefs.SetFloat("upgradeEngineTorque", Engine[0]._vehicleTorque.engineTorque);
        Engine[1]._vehicleTorque.maxVelocityKMh +=20;
        Engine[2]._vehicleTorque.numberOfGears +=2;
        Engine[3]._vehicleTorque.speedOfGear +=0.2f;
        
        slider[0].value = Engine[0]._vehicleTorque.engineTorque ;
        slider[1].value = Engine[1]._vehicleTorque.maxVelocityKMh ;
        slider[2].value = Engine[2]._vehicleTorque.numberOfGears ;
        slider[3].value = Engine[3]._vehicleTorque.speedOfGear;
       // PlayerPrefs.SetFloat("engineTor", Engine[0]._vehicleTorque.engineTorque);
    }

   
    public void upgradeFirst()
    {
       

        slider[0].value = Engine[0]._vehicleTorque.engineTorque;
        slider[1].value = Engine[1]._vehicleTorque.maxVelocityKMh;
        slider[2].value = Engine[2]._vehicleTorque.numberOfGears;
        slider[3].value = Engine[3]._vehicleTorque.speedOfGear;
        PlayerPrefs.SetFloat("engineTor", Engine[0]._vehicleTorque.engineTorque);
    }
    public void egalValue()
    {
         slider[0].value = Engine[0]._vehicleTorque.engineTorque;
         slider[1].value = Engine[1]._vehicleTorque.maxVelocityKMh;
         slider[2].value = Engine[2]._vehicleTorque.numberOfGears;
         slider[3].value = Engine[3]._vehicleTorque.speedOfGear;
    }
   
    public void SaveCharacterSelected()
    {
        
        PlayerPrefs.SetInt("upgrade", save.CurentCharacterUp);
        Debug.Log("CurrernCharacter Up = " + save.CurentCharacterUp);
    }
    void LoadCharacterSelected()
    {
        SvVal1 = PlayerPrefs.GetFloat("upgradeEngineTorque");
        Debug.Log("Salvarea 1 " + SvVal1);
        current = PlayerPrefs.GetInt("upgrade");
        
       Et = PlayerPrefs.GetFloat("upgarde");

    }
    void LoadSlider()
    {
       slider[0].value =  Et;
       
    }
    void egaleaz()
    {
        Debug.Log("current = " + current);   
        for (int i = current  ; i < current  + 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Engine[j] = asign.vehicalsUpgrades[i];

            }
        }
    }
    
}
