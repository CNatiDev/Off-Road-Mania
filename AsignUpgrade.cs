using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignUpgrade : MonoBehaviour
{
    public CharacterSelection selectedcharacter;
    public SliderUpgarde sliders;
    public MSVehicleControllerFree[] vehicalsUpgrades;
    public SaveLoadCarSelected save; 
    int k;
    int Save_kr ;
    int Save_sc ;
    public void creste()
    {
        Debug.Log("save.CurentCharacterUp = " + save.CurentCharacterUp);

        k = save.CurentCharacterUp;
        Debug.Log("save.CurentCharacterUp2 = " + k);
        for (int i = k; i < k + 4; i++)
            for (int j = 0; j < 4; j++)
            {

                sliders.Engine[j] = vehicalsUpgrades[i];
            }
       

        if (k == 36)
            k = 0;

    }
    public void scade()
    {
       
         k = save.CurentCharacterUp;
        
        for (int i = k+3; i >= k ; i--)
            for (int j = 0; j < 4; j++)
            {

                sliders.Engine[j] = vehicalsUpgrades[i];
            }
      
        if (k == 0)
            k = 40;
       
    }

  
   
    

}
