using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyObsticaleHitMarker : MonoBehaviour
{
    [SerializeField] public int health = 40;
    public int Points = 10;
    public SpriteRenderer damageTint;
    private bool vulnerable;
    public bool tookDamage;
    [SerializeField] public float waitTime = 0.5f;
    [SerializeField] public float timerTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        damageTint = GetComponent<SpriteRenderer>();
        timerTime = waitTime;
        tookDamage = false;
    }

    // Update is called once per frame
    public void Update()
    {
        timerTime -= Time.deltaTime;

        if(tookDamage == true)
        {  
            tookDamage = false;
            timerTime = waitTime;  
        }

        if(timerTime <= 0)
        {      
            damageTint.color = new Color(1, 1, 1);
        }

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
        tookDamage = true;
        damageTint.color = new Color(1, 0, 0);
    }

    public void OnDestroy()
    {
        //int PointBoost = FindAnyObjectByType<Scoreboard>().Score;
        //FindAnyObjectByType<Scoreboard>().Score = PointBoost + Points;
    }


}
