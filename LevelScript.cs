using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelScript : MonoBehaviour
{

    public GameObject FinalTrigerMask;
    public GameObject FinalPanel;
    public GameObject BunttonMeniu;
    public LoadCharacter Clona;
    public int LevelReward;
    public int MoneyAmountCurrentt;
    private void Start()
    {
        
        MoneyAmountCurrentt = PlayerPrefs.GetInt("MoneyAmountCurrent");
    }
    public void Pass()
    {
        MoneyAmountCurrentt += LevelReward;
        PlayerPrefs.SetInt("MoneyAmountCurrent", MoneyAmountCurrentt);
        Debug.Log("Money  " + MoneyAmountCurrentt);

        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentLevel + "curentLevel");
        if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlocked"))
        {
            PlayerPrefs.SetInt("levelIsUnlocked", currentLevel +1 );
        }
       
        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlocked") + " UNLOCKED");
        Debug.Log("Finallll");
        FinalTrigerMask.SetActive(false);
        FinalPanel.SetActive(true);
        BunttonMeniu.SetActive(false);
        Clona.clona.GetComponent<EnWh>().CanavasDisable.SetActive(false);
        Clona.clona.GetComponent<MSVehicleControllerFree>().handBrakeTrue = true;
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tr")
        {
            Pass();
            
        }    
    }
 
}