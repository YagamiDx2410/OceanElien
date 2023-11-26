using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPopup : MonoBehaviour
{
    [SerializeField] Toggle _soundToggle;
    [SerializeField] Toggle _vibroToggle;


    public void OnclickCancel()
    {
        UIPopupManager.Instance.HidePopup(UIPopupName.settingPopup);
    }

    public void OnClickSound()
    {
        Debug.Log("Onclick Sound");
    }
    public void OnClickVibro()
    {
        Debug.Log("Onclick Vibro");
    }
}
