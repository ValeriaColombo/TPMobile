using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject popupShop;
    [SerializeField] private GameObject popupSettings;
    [SerializeField] private Toggle superPowerToggle;

    private void Start()
    {
        popupShop.SetActive(false);
        popupSettings.SetActive(false);
    }

    public void OnClickRewardedAd()
    {
        Debug.LogError("No ad loaded right now");
    }

    public void OnSuperPowerToggle()
    {
        if(superPowerToggle.isOn)
            Debug.Log("SuperPower is now Active");
        else
            Debug.Log("SuperPower is now inactive");
    }


    public void OnOpenShopClick()
    {
        popupShop.SetActive(true);
        popupSettings.SetActive(false);
    }

    public void OnOpenSettingsClick()
    {
        popupShop.SetActive(false);
        popupSettings.SetActive(true);
    }

    public void OnCloseShopClick()
    {
        popupShop.SetActive(false);
        popupSettings.SetActive(false);
    }

    public void OnCloseSettingsClick()
    {
        popupShop.SetActive(false);
        popupSettings.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (popupSettings.activeSelf)
            {
                OnCloseSettingsClick();
            }
            else if (popupShop.activeSelf)
            {
//                OnCloseShopClick();
            }
            else
            {
                OnOpenSettingsClick();
//                Application.Quit();
            }
        }
    }
}
