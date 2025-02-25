using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyObsticaleHitMarker : MonoBehaviour
{
    [SerializeField] public int health = 40;
    
    private bool vulnerable;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Weapon")
        {
            health -= 1;
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    

}
