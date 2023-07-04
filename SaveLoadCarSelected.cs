using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadCarSelected : MonoBehaviour
{
    public CharacterSelection character_selectio;
    
   public int CurentCharacter;
    public int CurentCharacterUp;
    public int CurentCharacterUpLoad;
    public SliderUpgarde slider;
   
       
    
    private void Start()
    {
        Invoke("LoadCharacterSelected", 0.1f);
    }
    public void SaveCharacterSelected()
    {
        PlayerPrefs.SetInt("selected", character_selectio.selectedCharacter);
        Debug.Log("sel CHARSEL =   " + character_selectio.selectedCharacter);
        PlayerPrefs.SetInt("upgrade", CurentCharacterUp);
    }
     void LoadCharacterSelected()
    {
      CurentCharacter = PlayerPrefs.GetInt("selected");
       Debug.Log("sel   " + CurentCharacter);
       // CurentCharacterUp = PlayerPrefs.GetInt("upgrade");
        Debug.Log("CurentCharacterUp  = " + CurentCharacterUp);
        //CurentCharacterUpLoad = PlayerPrefs.GetInt("upgrade");

        CurentCharacterUp = character_selectio.selectedCharacter * 4;
        CurentCharacterUpLoad = CurentCharacterUp;
    }
    public void Creste4()
    {
     
        /*if (CurentCharacterUp < 0)
            CurentCharacterUp = CurentCharacterUp * -1;
        else
            CurentCharacterUp += 4;
            CurentCharacterUpLoad += 4;
        if (CurentCharacterUp > 36)
        {
            CurentCharacterUp = 0;
            CurentCharacterUpLoad = 0;
        }*/
        CurentCharacterUp = character_selectio.selectedCharacter * 4;
        CurentCharacterUpLoad = CurentCharacterUp;
        Debug.Log("Curent = " + CurentCharacterUp);
    }
    public void Scade4()
    {
        //   Debug.Log("Curent = " + CurentCharacter);
        /*if (CurentCharacterUp == 0)
        {
            CurentCharacterUpLoad = 36;
           CurentCharacterUp = 36;
        }
        else
        if (CurentCharacterUp < 0)
        {
            CurentCharacterUp = CurentCharacterUp * -1; 
        }
        else
        {
            CurentCharacterUp -= 4;
            CurentCharacterUpLoad -= 4;

        }*/
        Debug.Log("DeScazut = " + character_selectio.selectedCharacter);
        if (CurentCharacterUp - 4 == -4)
        {
            CurentCharacterUp = 36;
            CurentCharacterUpLoad = CurentCharacterUp;
        }
        else

        {
            CurentCharacterUp = CurentCharacterUp - 4;
            Debug.Log("CurentScade = " + CurentCharacterUp);
        }

    }
}