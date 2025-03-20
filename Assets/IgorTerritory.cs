using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorTerritory : MonoBehaviour
{
    public GameObject switchButton;

    public void Start() 
    {
        switchButton.SetActive(false);    
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
