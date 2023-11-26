using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UpgradeItem : MonoBehaviour
{
    [SerializeField] Image _icon;
    [SerializeField] TextMeshProUGUI _upgradeItemName;
    [SerializeField] TextMeshProUGUI _description;
    [SerializeField] TextMeshProUGUI _conditionLevelText;
    [SerializeField] Image _conditionItemImage;
    [SerializeField] TextMeshProUGUI _conditionItemText;
    [SerializeField] Image _subConditionItemImage;
    [SerializeField] TextMeshProUGUI _subConditionItemText;
    [SerializeField] TextMeshProUGUI _mainConditionText;

    //this is for Getcondition
    [SerializeField] GameObject GetconditionPanel;

    public UpgradeItemSO item;

    public void AddItem(UpgradeItemSO itemAdd)
    {
        item = itemAdd;
        UpdateUIUpgradeItem();
        Debug.Log("Add Item " + item.upgradeName);
    }

    public void Onclick()
    {
        //  UIPopupManager.Instance.GetPopup(UIPopupName.upgradePopup).GetComponent<UpgradePopup>().SetSelectedItem(this,this.gameObject); ;
        if (OnGetCondition())
        {
            Debug.Log("Onclick Item");
            GetconditionPanel.SetActive(false);
            //GetconditionPanel.SetActive(!OnGetCondition());
        }
    }


    public void UpdateUIUpgradeItem()
    {
        if (item == null) return;
        _icon.sprite = item.Icon;
        _upgradeItemName.text = item.upgradeName;
        _description.text = item.descripion;
        _conditionLevelText.text = item.conditionLevel.ToString();
        _conditionItemImage.sprite = item.conditionImage;
        _conditionItemText.text = item.conditionValue.ToString();
        _mainConditionText.text = item.mainConditionValue.ToString();
    }

    public bool OnGetCondition()
    {
        if (true)
        {
            Debug.Log("GetCondition");
            return true;
        }
        return false;
    }

    public bool OngetSubTypeCondtion()
    {
        if (true)
        {
            Debug.Log("true");
            return true;
        }
        return false;
    }

}
