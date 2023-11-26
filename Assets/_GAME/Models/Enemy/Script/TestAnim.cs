using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnim : MonoBehaviour
{
    public GameObject[] walkPoint;
    int currentZombiePosition;
    public float ZombieSpeed;
    public float walkingPointRadius;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(walkPoint[currentZombiePosition].transform.position, transform.position) < walkingPointRadius)
        {
            currentZombiePosition = Random.Range(0, walkPoint.Length);
            if (currentZombiePosition >= walkPoint.Length)
            {
                currentZombiePosition = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, walkPoint[currentZombiePosition].transform.position, Time.deltaTime * ZombieSpeed);
        transform.LookAt(walkPoint[currentZombiePosition].transform.position);
    }
}
