using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WeaponAreaScript : MonoBehaviour
{
    
    public Collider2D attackArea;
    public bool attackAreaSwitch = false;


    // Update is called once per frame
    public void Update()
    {
        attackArea.enabled = attackAreaSwitch;
    }

    public void AttackSwitchFunc()
    {
        attackAreaSwitch = !attackAreaSwitch;
    }
}
