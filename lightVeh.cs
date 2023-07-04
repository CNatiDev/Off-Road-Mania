using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class lightVeh : MonoBehaviour
{


	[HideInInspector]
	public float buttonInput;
	[Tooltip("The sensitivity perceived by the script when pressing the button.")]
	public float sensibility = 3;
	bool pressing;

	public void OnPointerDown(PointerEventData eventData)
	{
		pressing = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pressing = false;
	}

	void Update()
	{
		if (pressing)
		{
			buttonInput += Time.deltaTime * sensibility;
		}
		else
		{
			buttonInput -= Time.deltaTime * sensibility;
		}
		buttonInput = Mathf.Clamp(buttonInput, 0, 1);
		if (pressing)
			Debug.LogWarning("red");
	}
}
