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
    FirstPersonMovement movement;
    interaction loopyshit;
    public Vector3 setPosition;

    manager Manager;


    // Start is called before the first frame update

    void Start()
    {
        
    }
    void Awake()
    {
    movement = froggerplay.GetComponent<FirstPersonMovement>();
    Manager = gamemanager.GetComponent<manager>();
    
        //playerControls = new Controls();
    //playerInput = GetComponent<PlayerInput>();

        froggerplay = GameObject.Find("FroggerPlayer");
        fpsplayer = GameObject.Find("First Person Controller");
        gamemanager = GameObject.Find("Manager");
    
    
    
    
    insidebox2 = true;
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(playgame) && (loopyshit.froggerspawned = true))
        {
            movement.canmove = true;
        }
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("end"))
        {
            Debug.Log("HELP ME");
            insidebox2 = false;
            fpsplayer.SetActive(true);
            
            transform.position = setPosition;
            Manager.tokencount ++;
            Debug.Log(Manager.tokencount);
            //froggerplay.SetActive(false);
            movement.canmove = false;

            
        }

        if (other.CompareTag("end 2"))
        {
            Debug.Log("HELP ME");
            
            //froggerplay.SetActive(false);
            
            transform.position = setPosition;
        }
        
    }
        
    }

    

