using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjMover : MonoBehaviour
{

    [SerializeField] private float speed;
    Rigidbody rb;
    public Transform endPoint;
    float distance;
    GameObject frogguy;
    
    private void Start() {
        rb = GetComponent<Rigidbody>(); // grab the rigidbody
        frogguy = GameObject.Find("FroggerPlayer");
        //endpoint = GameObject.Find("pointB");
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed; //Move the obj
                
        distance = Vector3.Distance (transform.position, endPoint.position); // check to see if the distance to end point 
              
        if (distance < 0.5f) // destroy if distance is small
        {
            frogguy.transform.SetParent(null);
            Destroy(this.gameObject);
        }
        
    }
}
