using UnityEngine;
using System.Collections;

/*Count time and create new cactus for us*/
public class PrefabsSpawner : MonoBehaviour {

    private float nextSpawnPointTime = 0;
    public Transform prefabToSpawn;
    public float spawnRateSeconds = 1;
    public float randomDelay = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextSpawnPointTime)
        {
            //Quaternion.identity - pretty much a zero value for rotation. 
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            nextSpawnPointTime = Time.time + spawnRateSeconds + Random.Range(0, randomDelay);
        }
	
	}
}
