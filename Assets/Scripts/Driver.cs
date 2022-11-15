using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [Header("CONFIG")]
    [SerializeField] private float steerSpeed = .1f;
    [SerializeField] private float moveSpeed = .01f;

    private float steerAmount;
    private float moveAmount;

    private void Update()
    {
        steerAmount = Input.GetAxis("Horizontal") * steerSpeed*Time.deltaTime;
        moveAmount = Input.GetAxis("Vertical")* moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
