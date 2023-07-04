using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBrake : MonoBehaviour
{
    public Transform Car;
    public float y = 4f;
    public float speed;
    public Vector3 direction;
    public MSVehicleControllerFree handBrake;
    public void Hand_Brake()
    {
        handBrake.handBrakeTrue = true;
        if(handBrake.handBrakeTrue = true)
        {
            Debug.Log("True");
        }
    }
    public void UpCar()
    {
        direction = new Vector3(0,+y,0);
        //Car.transform.position = new Vector3(Car.transform.position.x,+0.2f, Car.transform.position.z);
        Car.transform.Translate(direction * speed * Time.deltaTime);
    }
    public void DownCar()
    {
        direction = new Vector3(0, -y, 0);
        //Car.transform.position = new Vector3(Car.transform.position.x,+0.2f, Car.transform.position.z);
        Car.transform.Translate(direction * speed * Time.deltaTime);
    }
}
