using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorPush : MonoBehaviour
{
    [SerializeField]public float pushPower = 10.0f;
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody2D>().velocity = Vector2.left * pushPower;
        }
        
    }

}
