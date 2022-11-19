using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Vector3 cameraOffset;

    private void LateUpdate()
    {
        FollowTarget();
    }
    private void FollowTarget()
    {
        transform.position = target.transform.position+cameraOffset;
    }
}
