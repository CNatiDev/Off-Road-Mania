using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpaunInXpoint : MonoBehaviour
{

    public  int y;
    public int y2;
    public LoadCharacter Vehicle;
    public GameObject[] sp;
    public GameObject clonaVehicle;
    public RespwnPoint p;
    public MSVehicleControllerFree clonaScriptVehicle;
   

    private void Start()
    {
      clonaVehicle = Vehicle.clona;
        clonaScriptVehicle = Vehicle.clona.GetComponent<MSVehicleControllerFree>();
    }
    public void ResetRotation()
    {
        clonaVehicle.transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void respawn()
    {
        y = p.pozitie;
        clonaScriptVehicle.handBrakeTrue = true;
        clonaVehicle.transform.position = new Vector3(sp[y].transform.position.x, sp[y].transform.position.y, sp[y].transform.position.z);
       

        clonaVehicle.transform.rotation = sp[y].transform.rotation;
        if (clonaVehicle.transform.rotation != sp[y].transform.rotation)
        {
            clonaVehicle.transform.rotation = sp[y].transform.rotation;
        }

        Debug.Log("executat1" + y);
    }
    public void respawn2()
    {
        y2 = p.pozitia3;
        
        clonaScriptVehicle.handBrakeTrue = true;
        clonaVehicle.transform.position = new Vector3(sp[y2].transform.position.x, sp[y2].transform.position.y, sp[y2].transform.position.z);

       
        clonaVehicle.transform.rotation = sp[y2].transform.rotation;
        if (clonaVehicle.transform.rotation != sp[y2].transform.rotation)
        {
            clonaVehicle.transform.rotation = sp[y2].transform.rotation;
        }
        Debug.Log("executat2" + y2);

    }
    public void Egaleaza()
    {
        clonaVehicle = Vehicle.clona;
        clonaScriptVehicle = Vehicle.clona.GetComponent<MSVehicleControllerFree>();
       
    }
    private void Awake()
    {
        Egaleaza();
    }

}
