using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Item : MonoBehaviour
{
     int value;
    [SerializeField] TextMeshProUGUI _text;


    public void SetValue(int valueSet)
    {
        value = valueSet;
        UpdateValue();
    }

    public void UpdateValue()
    {
        _text.text = value.ToString();
    }
}
