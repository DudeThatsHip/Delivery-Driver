using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

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
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
        }

    }


}
