using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelScriptChalenge : MonoBehaviour
{
    public ParticleSystem[] Torch;
    public ReSpaunInXpoint reSpaunInXpoint;
    public GameObject Final_Panel;
    public GameObject ButtonCanavasLevel;
    public LoadCharacter Clona;
    public int LevelReward;
    public int MoneyAmountCurrentt;
    private void Start()
    {

        MoneyAmountCurrentt = PlayerPrefs.GetInt("MoneyAmountCurrent");
    }
    public void Pass1()
    {
        MoneyAmountCurrentt += LevelReward;
        PlayerPrefs.SetInt("MoneyAmountCurrent", MoneyAmountCurrentt);

        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlockedChalenge"))
        {
            PlayerPrefs.SetInt("levelIsUnlockedChalenge", currentLevel + 1);
        }
        Clona.clona.GetComponent<EnWh>().CanavasDisable.SetActive(false);
        Torch[0].enableEmission = true;
        Torch[1].enableEmission = true;
        reSpaunInXpoint.enabled = false;
        Final_Panel.SetActive(true);
        ButtonCanavasLevel.SetActive(false);
        /* Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlockedChalenge") + " UNLOCKED");
         Debug.Log("scenaActiva: " + SceneManager.GetActiveScene().buildIndex);*/
    }
    private void Hnadbarake()
    {
        //Clona.clona.GetComponent<MSVehicleControllerFree>().handBrakeTrue = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tr")
        {
            Pass1();
            Invoke("Hnadbarake", 1.5f);
        }
    }
}
