using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemy2;
    public Vector3 centre;
    public Vector3 size;
    public GameObject block;
    public int noOfBlocks;
    public Color[] theseColors;
    public GameObject[] theseModels;
    Vector3 spawnPos;
    Transform holder;
    
    public int BlockAmount;
    // Start is called before the first frame update
    void Start()
    {
        holder = GameObject.Find("RealTrash").transform;
        
        
        for (int i = 0; i < noOfBlocks; i++)
        {
            spawnPos = (transform.localPosition + centre) + new Vector3 (Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            block = theseModels[Random.Range(0,theseModels.Length)];
            //blockObj.transform.GetComponent<Renderer>().material.color = theseColors[Random.Range(0,theseColors.Length)];

            GameObject enemy2Obj = Instantiate(block, spawnPos, Quaternion.identity);
            enemy2Obj.transform.parent = holder;
        
            GameObject enemyObj = Instantiate(block);
            enemyObj.transform.parent = holder;

        }
        
        
        BlockAmount = noOfBlocks;

 
    }

    void Update()
    {
        
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = new Color (1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition + centre, size);   


    }
}
    
    
