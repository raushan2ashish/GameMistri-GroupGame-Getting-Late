using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickThrower : MonoBehaviour
{
    [SerializeField] public float waitTime = 5.0f;
    [SerializeField] public float timerTime = 5.0f;
    [SerializeField] public GameObject brickPrefab;
    [SerializeField] public GameObject player;
    [SerializeField] public GameObject territory;
    [SerializeField] public float brickSpeed = 5.0f;
    public GameObject newBrick;
    public bool isSpawning;
    
     
    
    
    public void Start() 
    {
        waitTime = timerTime;
    }
    
    //Checks if the spawner is working or not, if not starts the spawning process
    public void Update()
    {
        if(isSpawning == false)
        {
            timerTime -= Time.deltaTime;
            if(timerTime <= 0)
            {
                isSpawning = true;
                timerTime = waitTime;
                ObjectSpawner();
            }
        }
    }

    //Spawns the selected prefab and reinitiates the spawner
    public void ObjectSpawner()
    {
        newBrick = Instantiate(brickPrefab, transform.position, Quaternion.identity);
        newBrick.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position).normalized * brickSpeed;
        isSpawning = false;
    }
}
