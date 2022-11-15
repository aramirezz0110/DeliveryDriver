using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision enter");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger enter");
    }
}
