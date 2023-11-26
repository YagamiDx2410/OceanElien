using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPopupManager : MonoBehaviour
{
    private static UIPopupManager instance; 
    public  static UIPopupManager Instance => instance; 


    [SerializeField] GameObject _mainPopup;
    [SerializeField] GameObject _statisticPopup;
    [SerializeField] GameObject _settingPopup;
    [SerializeField] GameObject _itemPopup;
    [SerializeField] GameObject _upgradePopup;

    private void Awake()
    {
        UIPopupManager.instance = this;
    }


    public GameObject GetPopup(UIPopupName name)
    {
        Debug.Log(name);
        switch (name)
        {
            case UIPopupName.mainPopup:
                Debug.Log("return MainPopup");
                return _mainPopup.gameObject;
                break;
            case UIPopupName.statisticPopup:
                Debug.Log("return statisticPopup");
                return _statisticPopup.gameObject;
                break;
            case UIPopupName.settingPopup:
                return _settingPopup.gameObject;
                break;
            case UIPopupName.itemPopup:
                return _itemPopup.gameObject;
                break;
            case UIPopupName.upgradePopup:
                return _upgradePopup.gameObject;
                break;
        }
        return null;
    }

    public void ShowPopup(UIPopupName name)
    {
        switch (name)
        {
            case UIPopupName.mainPopup:
                Debug.Log("return MainPopup");
                _mainPopup.SetActive(true);
                break;
            case UIPopupName.statisticPopup:
                Debug.Log("return statisticPopup");
                _statisticPopup.SetActive(true);
                break;
            case UIPopupName.settingPopup:
                _settingPopup.SetActive(true);
                break;
            case UIPopupName.itemPopup:
                 _itemPopup.SetActive(true); 
                break;
            case UIPopupName.upgradePopup:
                _upgradePopup.SetActive(true); 
                break;
        }

    }
    public void HidePopup(UIPopupName name)
    {
        switch (name)
        {
            case UIPopupName.mainPopup:
                _mainPopup.SetActive(false);
                break;
            case UIPopupName.statisticPopup:
                _statisticPopup.SetActive(false);
                break;
            case UIPopupName.settingPopup:
                _settingPopup.SetActive(false);
                break;
            case UIPopupName.itemPopup:
                _itemPopup.SetActive(false); 
                break;
            case UIPopupName.upgradePopup:
                _upgradePopup.SetActive(false); 
                break;
        }

    }

}
