using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainPopup : MonoBehaviour
{
    // this is for level
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] TextMeshProUGUI _levelValueText;
    [SerializeField] Image _levelFill;

    //this is for Hp
    [SerializeField] Image _hpFill;
    [SerializeField] TextMeshProUGUI _hpText;

    //this is for food
    [SerializeField] TextMeshProUGUI _foodText;

    //this is for item
    [SerializeField] TextMeshProUGUI _itemText;

    //this is for Dimond
    [SerializeField] TextMeshProUGUI _dimondText;

    //this is for selection
    [SerializeField] TextMeshProUGUI _selectionText;
    [SerializeField] Image _SelectionFill;
    [SerializeField] TextMeshProUGUI _selectionValueText;

    public void OnclickAddFood()
    {
        Debug.Log("OnclickFood");
    }

    public void OnclickAddItem()
    {
        Debug.Log("AddItem");
    }

    public void OnclickStatic()
    {
        UIPopupManager.Instance.ShowPopup(UIPopupName.statisticPopup);
        Debug.Log("Onclick Static");
    }

    public void OnclickSetting()
    {
        UIPopupManager.Instance.ShowPopup(UIPopupName.settingPopup);
        Debug.Log("Onclick Setting");
    }

    public void OnClickItem()
    {
        UIPopupManager.Instance.ShowPopup(UIPopupName.itemPopup);
        UIPopupManager.Instance.GetPopup(UIPopupName.itemPopup).GetComponent<ItemPopup>().ShowItem();
        Debug.Log("OnClick Item");
    }

    public void OnClickBonus()
    {
        UIPopupManager.Instance.ShowPopup(UIPopupName.upgradePopup);
    }

    public void OnClickShop()
    {
        Debug.Log("Onclick shop");
    }

    public void OnClickUpgrade()
    {
        UIPopupManager.Instance.ShowPopup(UIPopupName.upgradePopup);
        UIPopupManager.Instance.GetPopup(UIPopupName.upgradePopup).GetComponent<UpgradePopup>().UpdateUpgradeListUI();
    }

    public void UpdateLevelUI(int level, float levelCurrentValue, float LevelMaxValue)
    {
        this._levelText.text = level.ToString();
        this._levelValueText.text = levelCurrentValue + "/" + LevelMaxValue;
        this._levelFill.fillAmount = levelCurrentValue / levelCurrentValue;
    }

    public void UpdateFoodUI(int foodValue) 
    {
        this._foodText.text = foodValue.ToString();
    }

    public void UpdateItemUI(int itemValue) 
    {
        this._itemText.text = itemValue.ToString();
    }

    public void UpdateDimondUI(int DimondValue) 
    {
        this._dimondText.text = DimondValue.ToString();
    }

    public void UpdateHPUI(float currentHp, float maxHp)
    {
        this._hpText.text = "HP (" + currentHp + "/" + maxHp + ")";
        this._hpFill.fillAmount = currentHp / maxHp;
    }
}
