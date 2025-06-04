using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class interaction : MonoBehaviour


{

     private Controls playerControls;
     private PlayerInput playerInput;
     
     private Vector2 interact;
     public KeyCode playgame = KeyCode.E;
     
     public GameObject fpsplayer;
     public GameObject froggerplay;

    public bool insidebox;
    movement movement;
    
    
    // Start is called before the first frame update
    void Start()
    {
        movement = froggerplay.GetComponent<movement>();
        playerControls = new Controls();
    playerInput = GetComponent<PlayerInput>();

    froggerplay = GameObject.Find("Capsule");
    fpsplayer = GameObject.Find("First Person Controller");
    //froggerplay.SetActive(false);
    movement.iffrog = false;
    
    //insidebox = true;
    }

    // Update is called once per frame
    
        void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("machine") && Input.GetKey(playgame))
        {
            Debug.Log("HELP ME");
            //insidebox = false;
            
            //froggerplay.SetActive(true);
            movement.iffrog = true;
            fpsplayer.SetActive(false);
            
        }
        
    }

     //&& insidebox == true
}
