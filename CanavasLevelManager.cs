using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CanavasLevelManager : MonoBehaviour
{
    public LoadCharacter Clona;
    public UnityAds ShowIntersertial;
    int CurentScene;
  
    // Start is called before the first frame update
    void Start()
    {
     
        CurentScene = SceneManager.GetActiveScene().buildIndex;
        ShowIntersertial.ShowInterstitial();
    }

   public void DisableVehicleCanavas()
    {
       
        Clona.clona.GetComponent<EnWh>().CanavasDisable.SetActive(false);
    }
    public void EnableVehicleCanavas()
    {
        Clona.clona.GetComponent<EnWh>().CanavasDisable.SetActive(true);
       
    }
    public void Reload()
    {
        SceneManager.LoadScene(CurentScene);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(CurentScene + 1);
    }
}
