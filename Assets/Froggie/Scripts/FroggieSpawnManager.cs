using Unity.VisualScripting;
using UnityEngine;

public class FroggieSpawnManager : MonoBehaviour
{

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private int minSections, maxSections;
    [SerializeField] private GameObject solidPlatform, cloudSection, rainbowSection;
    [SerializeField] private int iterations; //amount of times it will spawn groups of sections;
    [SerializeField] private float moveDistance; // distane between sections;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlatforms();
    }

    private void SpawnPlatforms()
    {
        float chooser; // vaibale for chosing the type
        int sectionAmount; // variable that holds how many we are spawning.



        for (int i = 0; i < iterations; i++) // spawns something for the amount of iterations.
        {
            sectionAmount = Random.Range(minSections, maxSections); // sets the amount of platforms it will spawn;
            chooser = Random.Range(0, 1f); //chooses the platform type
            
            for (int j = 0; j < sectionAmount; j++) // spawns the chosen obj the amount of times in chooser
            {
                spawnPoint.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z + moveDistance);
                if (chooser >= 0.5f)
                {
                    GameObject sectionObj = Instantiate(cloudSection, spawnPoint);
                    sectionObj.transform.parent = this.gameObject.transform;
                }
                else
                {
                    GameObject sectionObj = Instantiate(rainbowSection, spawnPoint);
                    sectionObj.transform.parent = this.gameObject.transform;
                }

            }

            spawnPoint.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z + moveDistance);
            GameObject solidObj = Instantiate(solidPlatform, spawnPoint); // spawns a solid
            solidObj.transform.parent = this.gameObject.transform;
            

        }
        
        
    }
}
