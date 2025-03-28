using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorStage : MonoBehaviour
{
    public EnemeyObsticaleHitMarker healthCheck;
    public GameObject stage2;
    public GameObject stage3;
    
    // Start is called before the first frame update
    public void Start()
    {
        healthCheck = GetComponent<EnemeyObsticaleHitMarker>();
        stage2.SetActive(false);
        stage3.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if(healthCheck.health <= 600 && healthCheck.health > 400)
        {
            stage2.SetActive(true);
        }
        else if(healthCheck.health <= 400 && healthCheck.health > 0)
        {
            stage3.SetActive(true);
        }
    }
}
