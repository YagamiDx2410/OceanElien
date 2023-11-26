using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


[CreateAssetMenu(fileName = "UpgradeItemSO", menuName = "New UpgradeItem")]
public class UpgradeItemSO : ScriptableObject
{
    public Sprite Icon;
    public string upgradeName;
    public string descripion;
    public int conditionLevel;
    public Sprite conditionImage;
    public int conditionValue;
    public Sprite subConditionImage;
    public int subConditionValue;
    public float mainConditionValue;
    public UpgradeType type;


    public void ChangeConditionValue(/*int newConditionLevel, Sprite newConditionImage, int newConditionValue, float newMainConditionValue*/) 
    {
        //conditionLevel = newConditionLevel;
        //conditionImage = newConditionImage;
        //conditionValue = newConditionValue;
        //mainConditionValue = newMainConditionValue;
    }

    //public void ChangeConditionValue(/*int newConditionLevel, Sprite newConditionImage, int newConditionValue, Sprite newSubConditionImage, int newSubConditionValue, float newMainConditionValue*/)
    //{
    //    conditionLevel = newConditionLevel;
    //    conditionImage = newConditionImage;
    //    conditionValue = newConditionValue;
    //    mainConditionValue = newMainConditionValue;
    //    subConditionImage = newSubConditionImage;
    //    subConditionValue = newSubConditionValue;
    //}
}
