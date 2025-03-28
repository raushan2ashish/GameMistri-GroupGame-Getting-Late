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
    [SerializeField] public float waitTimeAftermath = 0.3f;
    [SerializeField] public float timerTime = 3.0f;

    public bool isAttacking = false;
    
    // Start is called before the first frame update
    public void Start()
    {
        healthCheck = GetComponent<EnemeyObsticaleHitMarker>();
        bossPush = GetComponent<Animator>();
        stage2.SetActive(false);
        stage3.SetActive(false);
        timerTime = waitTime;
        isAttacking = false;
    }

    // Update is called once per frame
    public void Update()
    {
        timerTime -= Time.deltaTime;

        if(timerTime <= 0 && isAttacking == false)
        {
            isAttacking = true;
            bossPush.SetTrigger("Attack");
            igorTerritory.PushPlayer();   
            timerTime = waitTime;
            isAttacking = false;        
        }
        
        if(healthCheck.health <= 600 && healthCheck.health > 400)
        {
            stage2.SetActive(true);
            waitTime *= 2/3;
        }
        else if(healthCheck.health <= 400 && healthCheck.health > 0)
        {
            stage3.SetActive(true);
            waitTime *= 1/3;
        }
    }
}
