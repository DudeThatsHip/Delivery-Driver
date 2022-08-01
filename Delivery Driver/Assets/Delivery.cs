using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    // this allows us to access the Sprite Renderer Component
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // when an incoming collider makes contact with this object's collider
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Wow you hit me!");
    }

    // it is when an object passes through another collider and triggers something
    void OnTriggerEnter2D(Collider2D other) 
    {
        // if (the thing we trigger is the package)
        // {
        //    then print "package picked up" to the console
        // }

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor; // this is how the Sprite Renderer is used
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

    }


}
