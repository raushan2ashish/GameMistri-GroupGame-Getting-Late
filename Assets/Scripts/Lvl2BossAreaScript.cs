using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2BossAreaScript : MonoBehaviour
{
    [SerializeField] public GameObject enemyObj;
    public bool bossActive;

    public void Start() 
    {
        enemyObj.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            enemyObj.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            enemyObj.SetActive(false);
        }
    }
}
