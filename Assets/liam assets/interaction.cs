using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
     public GameObject paddleB;
     public GameObject paddleI;

    public bool insidebox;
    movement movement;
    
    interaction1 interaction1;
    movement3 movement3;
    movement2 movement2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        movement = froggerplay.GetComponent<movement>();
        interaction1 = froggerplay.GetComponent<interaction1>();
        movement2 = paddleB.GetComponent<movement2>();
        movement3 = paddleI.GetComponent<movement3>();
        playerControls = new Controls();
    playerInput = GetComponent<PlayerInput>();

    froggerplay = GameObject.Find("Capsule");
    fpsplayer = GameObject.Find("First Person Controller");
    paddleB = GameObject.Find("paddle");
    paddleI = GameObject.Find("paddle2");
    //froggerplay.SetActive(false);
    movement.iffrog = false;
    paddleB.SetActive(false);
    paddleI.SetActive(false);
       
    
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
            interaction1.insidebox2 = true;
            
            
        }

         if (other.CompareTag("breakout") && Input.GetKey(playgame))
        {
            Debug.Log("HELP ME");
            //insidebox = false;
            
            //froggerplay.SetActive(true);
            fpsplayer.SetActive(false);
            paddleB.SetActive(true);


            
            
        }

         if (other.CompareTag("invaderz") && Input.GetKey(playgame))
        {
            Debug.Log("HELP ME");
            //insidebox = false;
            
            //froggerplay.SetActive(true);
            fpsplayer.SetActive(false);
            paddleI.SetActive(true);


            
            
        }
        
    }
    

     //&& insidebox == true
}
