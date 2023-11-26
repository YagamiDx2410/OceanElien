using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform ObjectToFollow;
    public Vector3 PositionOffset = new Vector3(0 , 9, -8);

    Transform currentObjectTransform;
    void Start()
    {
        currentObjectTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentObjectTransform.position = ObjectToFollow.position + PositionOffset;
    }
}
