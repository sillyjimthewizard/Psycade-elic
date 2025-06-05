using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public bool CanSpin;

    public int degree;
    public int degree2;
    public float degreesPerSecond = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        
        
        if (CanSpin == true)
        {
            transform.Rotate(0, 0,degreesPerSecond * Time.deltaTime);
        }
    }


    // Update is called once per frame
    public void SPIN()
	{
		degree = degree + degree2;
		transform.Rotate(0, 0, degree);
		Debug.Log("whatever");
		Debug.Log(degree);
        degree = degree - degree2;
	}
}
