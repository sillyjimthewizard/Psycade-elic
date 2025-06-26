using System.Collections;
using System.Collections.Generic;
using TMPro;
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
     public GameObject paddlef;
     public GameObject paddleB;
     public GameObject paddleI;
    public GameObject froggergame;

    public GameObject spawner;

    public bool froggerspawned;

     public GameObject breakout;

    public bool insidebox;
    FirstPersonMovement movement;
    
    public interaction1 interaction1;
    movement3 movement3;
    movement2 movement2;

    public AudienceManager spawning; 

    public GameObject froggercam;
    public GameObject ball;
    public impulse ballshoot;

    public Rigidbody theball;


    // Start is called before the first frame update

    void Awake()
    {
        fpsplayer = GameObject.Find("First Person Controller");
    }
    void Start()
    {

        
        paddleB = GameObject.Find("paddle");
        paddleI = GameObject.Find("invaderpaddle");
        
        breakout = GameObject.Find ("breakout");
        froggergame = GameObject.Find("frogger (1)");
        froggerspawned = true; 
        



        movement = froggerplay.GetComponent<FirstPersonMovement>();
        interaction1 = froggerplay.GetComponent<interaction1>();
        movement2 = paddleB.GetComponent<movement2>();
        movement3 = paddleI.GetComponent<movement3>();
        playerControls = new Controls();
        playerInput = GetComponent<PlayerInput>();
        

    //froggerplay = GameObject.Find("Capsule");
        
    //froggerplay.SetActive(false);
        //movement.iffrog = false;
        paddleB.SetActive(false);
        paddleI.SetActive(false);
        //paddlef.SetActive(false);
        breakout.SetActive(false);
       
    
    //insidebox = true;
    }

    // Update is called once per frame
    
        void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("machine") && Input.GetKey(playgame))
        {

            //froggergame.SetActive(true);
            froggerspawned = true;
            froggercam.SetActive(true);
            fpsplayer.SetActive(false);
            
            
        
            //interaction1.insidebox2 = true;
            
            
            
            //insidebox = false;

            //froggerplay.SetActive(true);
            //paddlef = GameObject.Find("FroggerPlayer");
            //paddlef.SetActive(true);#
        
            
        }

         if (other.CompareTag("breakout") && Input.GetKey(playgame))
        {
            Debug.Log("HELP ME");
            //insidebox = false;
            
            //froggerplay.SetActive(true);
            spawning.Breakoutstart();
            ballshoot.started = false;
            
            ball.transform.localPosition = new Vector3(-38.28f,-1.776146f,1084.66f);
            paddleB.SetActive(true);
            breakout.SetActive(true);
            froggercam.SetActive(false);
            fpsplayer.SetActive(false);

            




            
            
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
