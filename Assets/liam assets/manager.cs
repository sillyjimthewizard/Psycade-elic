using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{

    public GameObject fpsplayer;
     public GameObject froggerplay;
     public int tokencount;
      movement movementfrog;
      movement2 movementfps;
    interaction1 interaction1;
     public KeyCode resetgame = KeyCode.R;
    public GameObject invaderz;


     
    // Start is called before the first frame update
    void Start()
    {
        froggerplay = GameObject.Find("FroggerPlayer");
        fpsplayer = GameObject.Find("First Person Controller");
        tokencount = 0;
        
        movementfrog = froggerplay.GetComponent<movement>();
        interaction1 = froggerplay.GetComponent<interaction1>();
        movementfps = fpsplayer.GetComponent<movement2>();
        fpsplayer.SetActive(false);
        invaderz = GameObject.Find("invaderpaddle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(resetgame))
        {
            fpsplayer.SetActive(true);
            froggerplay.SetActive(false);
            invaderz.SetActive(false);
            
            

        }

    }
}
