using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class interaction1 : MonoBehaviour


{

     //private Controls playerControls;
     //private PlayerInput playerInput;
     
     //private Vector2 interact;
     public KeyCode playgame = KeyCode.E;
     
     public GameObject fpsplayer;
     public GameObject froggerplay;

     public GameObject gamemanager;

    public bool insidebox2;
    movement movement;
    public Vector3 setPosition;

    manager Manager;
    
    
    // Start is called before the first frame update
    void Start()
    {
    movement = froggerplay.GetComponent<movement>();
    Manager = gamemanager.GetComponent<manager>();
    movement.iffrog = false;
        //playerControls = new Controls();
    //playerInput = GetComponent<PlayerInput>();

    froggerplay = GameObject.Find("Capsule");
    fpsplayer = GameObject.Find("First Person Controller");
    gamemanager = GameObject.Find("Manager");
    
    
    
    
    insidebox2 = true;
    }

    // Update is called once per frame
    
        void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("end") && insidebox2 == true)
        {
            Debug.Log("HELP ME");
            insidebox2 = false;
            fpsplayer.SetActive(true);
            //froggerplay.SetActive(false);
            movement.iffrog = false;
            transform.position = setPosition;
            Manager.tokencount ++;
            Debug.Log(Manager.tokencount);
        }
        
    }

    
}
