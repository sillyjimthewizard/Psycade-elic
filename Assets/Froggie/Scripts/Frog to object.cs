using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogtoobject : MonoBehaviour
{
    public GameObject Frog;
    public GameObject UFO;
 
    bool Platmove = false;
 
    void Start()
    {
        // Initialize Platmove to false
        Platmove = false;
    }
 
    void Update()
    {
        // It’s inefficient to call Find every frame.
        // If you must do it, consider caching or finding once.
        if (Frog == null)
        {
            Frog = GameObject.Find("FroggerPlayer");
        }
    }
 
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Child maker"))
        {
            // Set this object’s parent to the other gameObject
            transform.SetParent(other.transform, true);
 
            // Set Platmove to true since collision happened
            Platmove = true;
        }
    }
 
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Child maker"))
        {
            // Remove parent when collision ends
            transform.SetParent(null);
 
            // Set Platmove to false when no longer colliding
            Platmove = false;
        }
    }

    
}
