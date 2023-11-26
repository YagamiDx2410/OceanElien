using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatisticPopup : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _attackPowerValueText;
    [SerializeField] TextMeshProUGUI _maxHitPointValueText;
    [SerializeField] TextMeshProUGUI _regenerationValueText;
    [SerializeField] TextMeshProUGUI _stomachValueText;
    [SerializeField] TextMeshProUGUI _radiusValueText;
    [SerializeField] TextMeshProUGUI _speedValueText;
    [SerializeField] TextMeshProUGUI _resourceMuitiplierValueText;
    [SerializeField] TextMeshProUGUI _expMuitiplierText;


    public void ChangeAttackPowerValueTextValue(int Value)
    {
        _attackPowerValueText.text = Value.ToString();
    }

    public void ChangeMaxHitPointValueTextValue(int Value)
    {
        _maxHitPointValueText.text = Value.ToString();
    }
    public void ChangeRegenerationValueTextValue(int Value)
    {
        _regenerationValueText.text = Value.ToString();
    }

    public void ChangeStomachValueTextValue(int Value)
    {
        _stomachValueText.text = Value.ToString();
    }

    public void ChangeRadiusValueTextValue(int Value)
    {
        _radiusValueText.text = Value.ToString();
    }

    public void ChangeSpeedValueTextValue(int Value)
    {
        _speedValueText.text = Value.ToString();
    }

    public void ChangeResourceMuitiplierValueTextValue(int Value)
    {
        _resourceMuitiplierValueText.text = Value.ToString();
    }

    public void ChangeExpMuitiplierTextValue(int Value)
    {
        _expMuitiplierText.text = Value.ToString();
    }

    public void OnClickCancel()
    {
        UIPopupManager.Instance.HidePopup(UIPopupName.statisticPopup);
    }




}
