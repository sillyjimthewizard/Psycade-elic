using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEditor.Rendering;

public class impulse : MonoBehaviour
{
    
    Rigidbody rig;

    public float degreesPerSecond = 2.0f;


    public bool rotate;
    public bool rotatedelta;
    public float magnitude = 5;
    
    public AudioClip enemycollission;
    
    public GameObject hitparticle;
    public GameObject blockparticle;
    
    public Color[] theseColors;
    public bool started;
    public GameObject helpTextobj;
    public Rigidbody yes;
    
    // Start is called before the first frame update
    void Start()
    {
    
      
       
      //helpTextobj = GameObject.Find("PressSpace");
      //helpTextobj.GetComponent<TMP_Text>().enabled = true;
      //helpTextobj.transform.DOScale(1.2f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
      
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !started)
        {
          rig=GetComponent<Rigidbody>();
          rig.AddForce(Vector3.forward*magnitude,ForceMode.Impulse);
          started = true;
          //helpTextobj.GetComponent<TMP_Text>().enabled = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotate == true)
        {
            transform.rotation = Random.rotation;
        }
        
        if (rotatedelta == true)
        {
            transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
        }

       if (started == false)
       {
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0,0,0);
 

       }

    }

     


     // public void OnColisionEnter(Collider other)
    //{
      /*  if (other.gameObject.CompareTag ("Hoop"))
        {
          Destroy (other.gameObject);
          Destroy(other.transform.parent.gameObject);
          Debug.Log("HELP ME");
        }
        
   }s
*/
    public void OnCollisionEnter(Collision other)
        {
        /*if (other.gameObject.CompareTag ("enemy"))
        {
          //rig.AddForce(Vector3.forward*magnitude,ForceMode.Impulse); //this make the ball move faster every hit
          
          Transform tempPosition;
          tempPosition = other.transform;
          
          GameObject particleClone = Instantiate (hitparticle, tempPosition);
          particleClone.transform.parent = null;
          Gradient grad = new Gradient();
          grad.SetKeys( new GradientColorKey[] { new GradientColorKey(theseColors[Random.Range(0,theseColors.Length)], 0f), new GradientColorKey(theseColors[Random.Range(0,theseColors.Length)], 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1f, 1f), new GradientAlphaKey(1f, 1.0f) } );
          ParticleSystem ps = particleClone.GetComponent<ParticleSystem>();
          var col = ps.colorOverLifetime;
          col.color = grad;
  
          audioscript.PlaySound(enemycollission);
          
          Destroy (other.gameObject);
          
          Debug.Log("HELP ME");
          
          manager.EnemyAmount --;
          
        }
        */
        if (other.gameObject.CompareTag ("block"))
        {
          Destroy (other.gameObject,0.1f);
          Debug.Log("plumb");
          rig.velocity = rig.velocity;
          //rig.AddForce(Vector3.forward*magnitude,ForceMode.Impulse); //this make the ball move faster every hit
          
          //Transform tempPosition;
          //tempPosition = other.transform;
          
          //GameObject particleClone = Instantiate (blockparticle, tempPosition);
          //particleClone.transform.parent = null;
          //Gradient grad = new Gradient();
          //grad.SetKeys( new GradientColorKey[] { new GradientColorKey(theseColors[Random.Range(0,theseColors.Length)], 0f), new GradientColorKey(theseColors[Random.Range(0,theseColors.Length)], 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0.2f, 1.0f) } );
          //ParticleSystem ps = particleClone.GetComponent<ParticleSystem>();
          //var col = ps.colorOverLifetime;
          //col.color = grad;

          
            
          
          
          
          
          
          
          
        }        
        
       /// if (other.gameObject.CompareTag ("paddle"))
        //{
          //rig.AddForce(Vector3.forward*magnitude,ForceMode.Impulse); //this make the ball move faster every hit
         /// magnitude = 2;
          ///rig.AddForce(Vector3.forward*magnitude,ForceMode.Impulse);
          
          
    
          
       // }        
        
/*
        if (other.gameObject.CompareTag ("delete"))
        {
          Destroy (gameObject);
          manager.ChooseGamer.SetActive(true);
          Destroy (manager.currentspawner);
          manager.ClearTrash();
          

        }
    */
   }
}
