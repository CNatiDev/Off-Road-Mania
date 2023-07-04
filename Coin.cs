using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool[] Sold1;
    void Start()
    {
    
       
        Sold1[1] = (PlayerPrefs.GetInt("Name1") != 0);
        Sold1[2] = (PlayerPrefs.GetInt("Name2") != 0);
        Sold1[3] = (PlayerPrefs.GetInt("Name3") != 0);
        Sold1[4] = (PlayerPrefs.GetInt("Name4") != 0);
        Sold1[5] = (PlayerPrefs.GetInt("Name5") != 0);
        Sold1[6] = (PlayerPrefs.GetInt("Name6") != 0);
        Sold1[7] = (PlayerPrefs.GetInt("Name7") != 0);
        Sold1[8] = (PlayerPrefs.GetInt("Name8") != 0);
        Sold1[9] = (PlayerPrefs.GetInt("Name9") != 0);
    }

    
}
