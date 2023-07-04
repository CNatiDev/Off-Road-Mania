using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFal : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 offsetBack;
    [SerializeField] private Vector3 offsetBack2;
    [SerializeField] Transform camera;
    [SerializeField] Transform firstPos;
    [SerializeField] public GameObject target;
    [SerializeField] private float translateSpeed;
    [SerializeField] private float rotationSpeed;
    public LoadCharacter Vehicul;
    private void Start()
    {
        offsetBack2 = offset;
        target = Vehicul.clona;
    }
    private void FixedUpdate()
    {
        HandleTranslation();
        HandleRotation();
    }

    private void HandleTranslation()
    {
        var targetPosition = Vehicul.clona.transform.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed * Time.deltaTime);
    }
    private void HandleRotation()
    {
        var direction = Vehicul.clona.transform.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
    public void BackCamera()
    {
        offset = new Vector3(offsetBack.x, offsetBack.y, offsetBack.z);
       
    }
    public void BackCamera2()
    {
        offset = new Vector3(offsetBack2.x, offsetBack2.y, offsetBack2.z);

    }
    public void CameraFisrstPosition()
    {
        camera.transform.position = new Vector3(firstPos.position.x, firstPos.position.y, firstPos.position.z);
        
    }
}