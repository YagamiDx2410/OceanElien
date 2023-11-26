using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemPopup : MonoBehaviour
{
    //this is item in scroll view
    [SerializeField] GameObject item;

    //this is button on obj
    [SerializeField] GameObject _buttonOn;

    //this is content of scrollview
    [SerializeField] Transform itemContent;


    //this is List for item
    List<Item> itemList = new List<Item>();



    public void ShowItem()
    {
        DestroyContent();
        foreach (var item in itemList)
        {
            Item obj = Instantiate(item, itemContent);
            obj.GetComponent<Item>().SetValue(1);
        }
    }

    public void SetList(List<Item> list)
    {
        itemList = list;
    }

   public void DestroyContent()
    {
        foreach (Transform child in this.itemContent)
        {
            Destroy(child.gameObject);
        }
    }


    public void OnclickitemOn()
    {
        UIPopupManager.Instance.HidePopup(UIPopupName.itemPopup);
    }

    

}
