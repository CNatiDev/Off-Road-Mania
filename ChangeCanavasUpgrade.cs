using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanavasUpgrade : MonoBehaviour
{

    public GameObject[] upgradePanels;
   
    int i = -1;
    public void NextPanel()
    {
        Debug.Log("i = " + i);
        if (i > 9)
        { i = 0; }
        else

        {
            i++;
           
        }
    }
    public void PerviousPanel()
    {
        Debug.Log("i = " + i);
        if (i < 0)
        {
            i = 0;
        }
        else
        {
            i--;
           
        }
    }
    public void openPanels()
    {
        upgradePanels[i].SetActive(true);
    }
}
