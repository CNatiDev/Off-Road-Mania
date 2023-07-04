using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int MoneyAmount;
    public int[] CarsPrice;
    public Button[] CarsButton;
    public Text MoneyText;
    public Image LockIcon;
    public bool[] Sold;
    public Button SelectButton;
    public Button ButtonUpgarde;
    public Button[] ButtonUpgardes;
    void Start()
    {
        MoneyAmount = PlayerPrefs.GetInt("MoneyAmountCurrent", 23000);
        MoneyText.text = MoneyAmount.ToString();
        for (int i = 0; i <= CarsButton.Length; i++)
        {
            if (CarsPrice[i] <= MoneyAmount)
            {
                CarsButton[i].interactable = true;
            }
        }

    }
    /*void Update()
    {
        for (int i = 0; i <= CarsButton.Length; i++)
        {
            if (CarsPrice[i] <= MoneyAmount)
            {
                CarsButton[i].interactable = true;
            }
        }
    }*/
    public void ChekButtonStatus()
    {
        for (int i = 0; i <= CarsButton.Length; i++)
        {
            if (CarsPrice[i] <= MoneyAmount)
            {
                CarsButton[i].interactable = true;
            }
        }
    }
    public void BuyCar(int CurrentCars)
    {
        MoneyAmount -= CarsPrice[CurrentCars];
        PlayerPrefs.SetInt("MoneyAmountCurrent", MoneyAmount);
        MoneyText.text = MoneyAmount.ToString();
        LockIcon.gameObject.SetActive(false);
        Sold[CurrentCars] = true;
        CarsButton[CurrentCars].gameObject.SetActive(false);
        SelectButton.interactable = true;
        ButtonUpgarde.interactable = true;
        Check();


    }
    public void UpgradeVehicleCoin()
    {

        MoneyAmount -= 7500;
        PlayerPrefs.SetInt("MoneyAmountCurrent", MoneyAmount);
        MoneyText.text = MoneyAmount.ToString();

    }
    public void Check()
    {
        if (Sold[0] == true)
        {
            PlayerPrefs.SetInt("Name", (Sold[0] ? 1 : 0));

        }
        if (Sold[1] == true)
        {
            PlayerPrefs.SetInt("Name1", (Sold[1] ? 1 : 0));
        }
        if (Sold[2] == true)
        {
            PlayerPrefs.SetInt("Name2", (Sold[2] ? 1 : 0));

        }
        if (Sold[3] == true)
        {
            PlayerPrefs.SetInt("Name3", (Sold[3] ? 1 : 0));

        }
        if (Sold[4] == true)
        {
            PlayerPrefs.SetInt("Name4", (Sold[4] ? 1 : 0));


        }
        if (Sold[5] == true)
        {
            PlayerPrefs.SetInt("Name5", (Sold[5] ? 1 : 0));

        }
        if (Sold[6] == true)
        {
            PlayerPrefs.SetInt("Name6", (Sold[6] ? 1 : 0));

        }
        if (Sold[7] == true)
        {
            PlayerPrefs.SetInt("Name7", (Sold[7] ? 1 : 0));

        }
        if (Sold[8] == true)
        {
            PlayerPrefs.SetInt("Name8", (Sold[8] ? 1 : 0));

        }
        if (Sold[9] == true)
        {
            PlayerPrefs.SetInt("Name9", (Sold[9] ? 1 : 0));

        }

    }
    public void Resett()
    {
        PlayerPrefs.DeleteKey("MoneyAmountCurrent");
        PlayerPrefs.DeleteKey("Name9");
        PlayerPrefs.DeleteKey("Name8");
        PlayerPrefs.DeleteKey("Name7");
        PlayerPrefs.DeleteKey("Name6");
        PlayerPrefs.DeleteKey("Name5");
        PlayerPrefs.DeleteKey("Name4");
        PlayerPrefs.DeleteKey("Name3");
        PlayerPrefs.DeleteKey("Name2");
        PlayerPrefs.DeleteKey("Name1");
        PlayerPrefs.DeleteKey("Name");

    }
    public void AddMoneyOnBuildTest()
    {
        MoneyAmount += 50000;
        PlayerPrefs.SetInt("MoneyAmountCurrent", MoneyAmount);
        MoneyText.text = MoneyAmount.ToString();
    }
   

   
}
