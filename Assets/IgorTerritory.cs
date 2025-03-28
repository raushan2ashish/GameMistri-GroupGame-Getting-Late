using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorTerritory : MonoBehaviour
{
    public GameObject switchButton;
    public bool isPushing;
    [SerializeField]public GameObject player;
    [SerializeField]public GameObject pushSpawner;
    [SerializeField]public GameObject pushLimit;
    [SerializeField]public GameObject pushLimitEnd;
    public Vector2 playerPos;
    public Vector2 pushPos;
    public Vector2 pushEnd;
    public float ePush;
    public float ePlayer;
    [SerializeField] public float attackPower = 10.0f;
    public Rigidbody2D playerRigBod;
    public PlayerMovementControl playerMovCon;
    public BrickThrower brickThrower;

    public void Start() 
    {
        switchButton.SetActive(false);
        playerPos = player.transform.position;
        pushPos = pushLimit.transform.position; 
        pushEnd = pushLimitEnd.transform.position;
        playerRigBod = player.GetComponent<Rigidbody2D>(); 
        playerMovCon = player.GetComponent<PlayerMovementControl>();
        brickThrower = pushSpawner.GetComponent<BrickThrower>();
    }

    public void Update() 
    {
        playerPos = player.transform.position;
        ePush = Vector3.Distance(pushPos, pushEnd);
        ePlayer = Vector3.Distance(playerPos, pushEnd);
    }

    public void PushPlayer() 
    {
        Debug.Log(ePush);
        Debug.Log(ePlayer);
        
        if(ePush >= ePlayer)
        {
            playerRigBod.velocity = new Vector3(-1, 1) * attackPower;
            brickThrower.ObjectSpawner();
        }
    } 

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
        switchButton.SetActive(true);
        }
    }
    
    public void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
        switchButton.SetActive(false);
        }
    }
}
