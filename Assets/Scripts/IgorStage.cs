using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorStage : MonoBehaviour
{
    public EnemeyObsticaleHitMarker healthCheck;
    
    // Start is called before the first frame update
    public void Start()
    {
        healthCheck = GetComponent<EnemeyObsticaleHitMarker>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(healthCheck.health <= 600 && healthCheck.health > 400)
        {
            Debug.Log("Stage2");
        }
        else if(healthCheck.health <= 400 && healthCheck.health > 0)
        {
            Debug.Log("Stage3");
        }
    }
}
