using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour
{

    [SerializeField] private Transform pointA, pointB;
    float Timer = 0;
    [SerializeField] private float minCloudTime, maxCloudTime;
    [SerializeField] private bool reverseDirection;
    [SerializeField] private GameObject spawnObj; 
    
    
    private void Awake() {
        Timer = Random.Range(1f, 2f);
    }


    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime; // this is the controller timer


        if (!reverseDirection) // makes it go left to right
        {
            if (Timer <= 0f)
            {
                GameObject tempCloud = Instantiate(spawnObj, pointA); //spawns the obj
                tempCloud.GetComponent<ObjMover>().endPoint = pointB; // sets its destroy point in the obj
                Timer = Random.Range(minCloudTime, maxCloudTime); // sets the next spawn time
            }
        }
        else if (reverseDirection) // makes it go right to left
        {
            if (Timer <= 0f)
            {
                GameObject tempCloud = Instantiate(spawnObj, pointB); //spawns the obj
                tempCloud.GetComponent<ObjMover>().endPoint = pointA; // sets its destroy point in the obj
                Timer = Random.Range(minCloudTime, maxCloudTime); // sets the next spawn time
            }
        }
    
        
    }
}
