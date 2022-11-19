using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Delivery : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 1f;
    private bool hasPackage = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GameTags.Package) && !hasPackage)
        {
            hasPackage = true;
            DestroyPackage(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(GameTags.Customer) && hasPackage)
        {
            hasPackage = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void DestroyPackage(GameObject package)=> Destroy(package, destroyDelay);
}
