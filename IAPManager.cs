using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Advertisements;
using UnityEngine.UI;
public class IAPManager : MonoBehaviour
{
    private string coin40000 = "com.ncsoftware.offroadmania4x4.coin40000";
    private string coin60000 = "com.ncsoftware.offroadmania4x4.coin60000";
    private string coin70000 = "com.ncsoftware.offroadmania4x4.coin70000";
    private string coin90000 = "com.ncsoftware.offroadmania4x4.coin90000";
    private string removeAds = "com.ncsoftware.offroadmania4x4.removeads";
    public GameObject RestoreButton;
    public Shop monaeyGet;
 

    private void Awake()
    {
        if(Application.platform != RuntimePlatform.IPhonePlayer)
        {
            RestoreButton.SetActive(false);
        }
      
    }
    public void OnPurcasheComplete(Product product)
  {
        if(product.definition.id == coin40000)
        {
            Debug.Log("You've gived 40000 coin");
            monaeyGet.MoneyAmount += 40000;
            monaeyGet.MoneyText.text = monaeyGet.MoneyAmount.ToString();
            PlayerPrefs.SetInt("MoneyAmountCurrent", monaeyGet.MoneyAmount);
        }
        if (product.definition.id == coin60000)
        {
            Debug.Log("You've gived 60000 coin");
            monaeyGet.MoneyAmount += 60000;
            monaeyGet.MoneyText.text = monaeyGet.MoneyAmount.ToString();
            PlayerPrefs.SetInt("MoneyAmountCurrent", monaeyGet.MoneyAmount);
        }
        if (product.definition.id == coin70000)
        {
            Debug.Log("You've gived 70000 coin");
            monaeyGet.MoneyAmount += 70000;
            monaeyGet.MoneyText.text = monaeyGet.MoneyAmount.ToString();
            PlayerPrefs.SetInt("MoneyAmountCurrent", monaeyGet.MoneyAmount);
        }
        if (product.definition.id == coin90000)
        {
            Debug.Log("You've gived 90000 coin");
            monaeyGet.MoneyAmount += 90000;
            monaeyGet.MoneyText.text = monaeyGet.MoneyAmount.ToString();
            PlayerPrefs.SetInt("MoneyAmountCurrent", monaeyGet.MoneyAmount);
        }
        if (product.definition.id == removeAds)
        {
            Debug.Log("removeAds");
       
            
        }
      
    }
    public void OnPurchaseFaield(Product product, PurchaseFailureReason purchaseFailureReason)
    {
        Debug.Log(product.definition.id + "failedBecause" + purchaseFailureReason);
    }
}
