using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorStage : MonoBehaviour
{
    public EnemeyObsticaleHitMarker healthCheck;
    [SerializeField] public IgorTerritory igorTerritory;
    public Animator bossPush;
    public GameObject stage2;
    public GameObject stage3;

    [SerializeField] public float waitTime = 3.0f;
    [SerializeField] public float attackWaitTime = 0.2f;
    [SerializeField] public float timerTime = 3.0f;
    [SerializeField] public float attackTimerTime = 0.2f;

    public bool isAttacking = false;
    
    // Start is called before the first frame update
    public void Start()
    {
        healthCheck = GetComponent<EnemeyObsticaleHitMarker>();
        bossPush = GetComponent<Animator>();
        stage2.SetActive(false);
        stage3.SetActive(false);
        timerTime = waitTime;
        attackTimerTime = attackWaitTime;
        isAttacking = false;
    }

    // Update is called once per frame
    public void Update()
    {
        timerTime -= Time.deltaTime;
        attackTimerTime -= Time.deltaTime;

        if(timerTime <= 0 && isAttacking == false)
        {
            //bossPush.SetBool("isAttacking", false);
            bossPush.SetTrigger("Attack");
            isAttacking = true;
            //bossPush.SetTrigger("Attack");
            //timerTime = waitTime;   
            igorTerritory.PushPlayer();
            timerTime = waitTime; 
            isAttacking = false;    
        }
        
        
        if(healthCheck.health <= 600 && healthCheck.health > 400)
        {
            stage2.SetActive(true);
            waitTime = 5;
        }
        else if(healthCheck.health <= 400 && healthCheck.health > 0)
        {
            stage3.SetActive(true);
            waitTime = 3;
        }
    }

    public void AttackEnd()
    {
        bossPush.SetBool("isAttacking", false);
    }
}
