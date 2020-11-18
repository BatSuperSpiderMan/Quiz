using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAP : MonoBehaviour
{
    public GameObject IAPButton;


    private void Start() 
    {
        /*if (PlayerPrefs.GetInt("NoAds") == 1)
        {
            IAPButton.SetActive(false); 
        }*/
    }

    public void OnPurchaseComplete(Product Purchase) 
    {
        PlayerPrefs.SetInt("NoAds", 1);
        IAPButton.SetActive(false);
    }

    public void OnPurchaseFailure(Product Purchase, PurchaseFailureReason reason)
    {
        Debug.Log(reason);
    }
}
