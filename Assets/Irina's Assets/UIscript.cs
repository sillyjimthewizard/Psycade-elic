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
    public int degree;

  

    // Start is called before the first frame update
    void Start()
    {
        
        titlescreen.enabled = true;
        main.enabled = false;
        options.enabled = false;
        canplay = true;
    }
    public void SPIN()
	{
		degree = degree + 1;
		transform.Rotate(0, 0, degree);
		Debug.Log("whatever");
		Debug.Log(degree);
	}

    public void Update()
    {
     
        if (Input.GetKey(KeyCode.Space) && (canplay = true))
        {
            titlescreen.enabled = false;
            main.enabled = true;
            options.enabled = false;
            canplay = false;

        }
    }
    public void OnPlay()
    {
        titlescreen.enabled = false;
        main.enabled = false;
        options.enabled = false;
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
