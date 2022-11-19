using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D), typeof(SpriteRenderer))]
public class Delivery : MonoBehaviour
{
    [Header("CONFIG")]
    [SerializeField] private float destroyDelay = 1f;    
    [Header("COLOR CONFIG")]
    [SerializeField] private Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] private Color32 noPackageColor = new Color32(1,1,1,1);

    private bool hasPackage = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GameTags.Package) && !hasPackage)
        {
            hasPackage = true;
            DestroyPackage(collision.gameObject);
            SetPlayerColor(hasPackageColor);
        }
        if (collision.gameObject.CompareTag(GameTags.Customer) && hasPackage)
        {            
            hasPackage = false;
            SetPlayerColor(noPackageColor);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void DestroyPackage(GameObject package)=> Destroy(package, destroyDelay);
    private void SetPlayerColor(Color32 customColor) => spriteRenderer.color = customColor;
}
