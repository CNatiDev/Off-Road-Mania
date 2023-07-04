using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightSet : MonoBehaviour
{
	public MSSceneControllerFree cars;
	public Button yourButton;
	public Light lm1;
	public Light lm2;
	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.LogWarning("You have clicked the button!");
		lm1.enabled = true;
		lm2.enabled = true;
	}
	public void CresteCar()
    {
		cars.startingVehicle=1;
    }
}


