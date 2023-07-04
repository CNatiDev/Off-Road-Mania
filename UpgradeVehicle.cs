using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeVehicle : MonoBehaviour
{
    public Slider[] slider;
    public MSVehicleControllerFree[] Engine;
    public string[] Function_Name;
    public int[] Ad_Geras_KMh;
    public float[] Ad_SpeedGears_Torque;
    void Start()
    {
        Engine[0]._vehicleTorque.engineTorque = PlayerPrefs.GetFloat(Function_Name[0],Ad_SpeedGears_Torque[0]);
        Engine[1]._vehicleTorque.maxVelocityKMh = PlayerPrefs.GetInt(Function_Name[1],Ad_Geras_KMh[0]);
        Engine[2]._vehicleTorque.numberOfGears = PlayerPrefs.GetInt(Function_Name[2],Ad_Geras_KMh[1]);
        Engine[3]._vehicleTorque.speedOfGear  = PlayerPrefs.GetFloat(Function_Name[3],Ad_SpeedGears_Torque[1]);
        slider[0].value = Engine[0]._vehicleTorque.engineTorque;
        slider[1].value = Engine[1]._vehicleTorque.maxVelocityKMh;
        slider[2].value = Engine[2]._vehicleTorque.numberOfGears;
        slider[3].value = Engine[3]._vehicleTorque.speedOfGear;
        
    }

    // Update is called once per frame
    public void Upgrade()
    {
        Engine[0]._vehicleTorque.engineTorque += 1.5f;
        //PlayerPrefs.SetFloat("upgradeEngineTorque", Engine[0]._vehicleTorque.engineTorque);
        Engine[1]._vehicleTorque.maxVelocityKMh += 20;
        Engine[2]._vehicleTorque.numberOfGears += 2;
        Engine[3]._vehicleTorque.speedOfGear += 0.2f;

        slider[0].value = Engine[0]._vehicleTorque.engineTorque;
        slider[1].value = Engine[1]._vehicleTorque.maxVelocityKMh;
        slider[2].value = Engine[2]._vehicleTorque.numberOfGears;
        slider[3].value = Engine[3]._vehicleTorque.speedOfGear;
        PlayerPrefs.SetFloat(Function_Name[0], Engine[0]._vehicleTorque.engineTorque);
        PlayerPrefs.SetInt(Function_Name[1], Engine[1]._vehicleTorque.maxVelocityKMh);
        PlayerPrefs.SetInt(Function_Name[2], Engine[2]._vehicleTorque.numberOfGears);
        PlayerPrefs.SetFloat(Function_Name[3], Engine[3]._vehicleTorque.speedOfGear);
    }
}
