using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDectection : MonoBehaviour
{
    public EnemyStats[] enemyStats;

    private void OnTriggerEnter(Collider Object)
    {
        if (Object.tag == "Enemies")
        {
            Debug.Log(Object.name);
            Debug.Log("What");
        }
    }

    private void OnTriggerStay(Collider Object)
    {
        if (Object.tag == "Enemies")
        {
            Debug.Log("asdsad");
        }
    }

    private void OnTriggerExit(Collider Object)
    {
        
    }

}
