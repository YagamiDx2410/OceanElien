using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradePopup : MonoBehaviour
{
    [SerializeField] GameObject _upgradeItemPrefab;
    [SerializeField] Transform _upgradeContent; //this is content of upgrade scrollview

    UpgradeItem selectedItemUpgrade;
    GameObject selectedObject;

    public List<UpgradeItemSO> upgradeList = new List<UpgradeItemSO>();
    public void OnClickCancel()
    {
        UIPopupManager.Instance.HidePopup(UIPopupName.upgradePopup);
    }
    public void UpdateUpgradeListUI()
    {
        DestroyContent();
        foreach (UpgradeItemSO item in this.upgradeList)
        {
            GameObject obj = Instantiate(_upgradeItemPrefab, _upgradeContent);
            obj.GetComponent<UpgradeItem>().AddItem(item);
        }

    }
    public void DestroyContent()
    {
        foreach (Transform child in this._upgradeContent)
        {
            Destroy(child.gameObject);
        }
    }

    public void SetSelectedItem(UpgradeItem itemSet, GameObject objSet)
    {
        selectedItemUpgrade = itemSet;
        selectedObject = objSet;
        OnUpgrade();
    }

    public void OnUpgrade()
    {
        ChangeUpgradeItem();
        ChangeUpgradePlayer();
    }

    public void ChangeUpgradeItem()
    {
        UpgradeItemSO item = FindIitemUpgradeInlist(selectedItemUpgrade.item.type);
        item.ChangeConditionValue(/*value new here*/);
        selectedItemUpgrade.GetComponent<UpgradeItem>().UpdateUIUpgradeItem();
    }

    public void ChangeUpgradePlayer() 
    {
        Debug.Log("Upgrade Player");
    }

    public UpgradeItemSO FindIitemUpgradeInlist(UpgradeType type)
    {
        foreach (UpgradeItemSO item in this.upgradeList)
        {
            if (item.type == type)
            {
                return item;
            }
        }
        return null;
    }



}
