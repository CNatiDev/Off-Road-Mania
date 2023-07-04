using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepawnController : MonoBehaviour
{
    [SerializeField]
    private int y;
    public LoadCharacter Vehicle;
    public GameObject[] sp;
    public GameObject clonaVehicle;
    public RespwnPoint p;
    float stopp = 0;
    int i = 0;
    public MSVehicleControllerFree clonaScriptVehicle;
    // Start is called before the first frame update
    void Start()
    {
        clonaVehicle = Vehicle.clona;
        clonaScriptVehicle = Vehicle.clona.GetComponent<MSVehicleControllerFree>();
        Debug.Log("cevaaaaaaaaaaaaaa");
        
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

        //clonaVehicle.transform.eulerAngles = new Vector3(sp[y].transform.rotation.x, sp[y].transform.rotation.y, sp[y].transform.rotation.z);
        clonaVehicle.transform.rotation = sp[y].transform.rotation;
        if (clonaVehicle.transform.rotation != sp[y].transform.rotation)
        {
            clonaVehicle.transform.rotation = sp[y].transform.rotation;
        }
    }
    public void Egaleaza()
    {
        clonaVehicle = Vehicle.clona;
        clonaScriptVehicle = Vehicle.clona.GetComponent<MSVehicleControllerFree>();
        Debug.Log("---------executat---------");
    }
}
