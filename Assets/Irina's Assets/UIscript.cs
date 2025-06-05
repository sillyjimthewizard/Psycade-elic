using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIscript : MonoBehaviour
{
    public Canvas titlescreen;
    public Canvas main;
    public Canvas options;
    public bool canplay;
    
    public GameObject gamemanager;
    manager Manager;
    movement2 movementfps;

    public GameObject fpsplayer;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("manager");
        fpsplayer = GameObject.Find("First Person Controller");
        Manager = gamemanager.GetComponent<manager>();
        movementfps = fpsplayer.GetComponent<movement2>();
        titlescreen.enabled = true;
        main.enabled = false;
        options.enabled = false;
        canplay = true;
    }

    public void Update()
    {
    
    
        if ((canplay == true) && Input.GetKey(KeyCode.Space))
        {
            titlescreen.enabled = false;
            main.enabled = true;
            options.enabled = false;
            canplay = false;
            Debug.Log("this is working owo");

        }
        
    }
    
    
    public void OnPlay()
    {
        titlescreen.enabled = false;
        main.enabled = false;
        options.enabled = false;
        fpsplayer.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        canplay = false;
        
    }
    public void OnOptions()
    {
        titlescreen.enabled = false;
        main.enabled = false;
        options.enabled = true;
    }
    public void OnQuit()
    {
        Application.Quit();
    }
    public void OnBack()
    {
        titlescreen.enabled = false;
        main.enabled = true;
        options.enabled = false;
    }
    
}
