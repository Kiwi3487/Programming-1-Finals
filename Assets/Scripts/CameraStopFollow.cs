using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStopFollow : MonoBehaviour
{
    private Transform playerTransform;
    private float previousY;
    private bool isFollowing = true;

    void Start()
    {
        playerTransform = transform.parent;
        previousY = playerTransform.position.y;
    }

    void Update()
    {
        if (isFollowing)
        {
            if (playerTransform.position.y != previousY)
            {
                StopFollowing();
            }
            
            previousY = playerTransform.position.y;
        }
    }

    void StopFollowing()
    {
        transform.parent = null;
        isFollowing = false;
    }
}