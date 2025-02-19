using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyObsticaleHitMarker : MonoBehaviour
{
    [SerializeField] public int health;
    bool vulnerable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            health -= 1;
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

}
