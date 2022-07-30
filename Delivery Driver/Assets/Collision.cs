using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    // when an incoming collider makes contact with this object's collider
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Wow you hit me!");
    }

    // it is when an object passes through another collider and triggers something
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("You stepped on me!!!");
    }


}
