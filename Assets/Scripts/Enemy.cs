using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int health;
    public float initPosY;
    public float updatePosY;
    public bool isActive;
    public bool isIdle = true;
    public bool movingRight = false;
    public bool facingRight = false;
    public Rigidbody2D rb;
    public Animator animator;

    

    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = 2;
        isActive = false;
        initPosY = transform.position.y;
    }

    // Update is called once per frame
    public void Update()
    {
        updatePosY = transform.position.y;
        if(rb.velocity.x < 0)
        {
            facingRight = false;
            isIdle = false;
            AnimationFlipper();
            animator.SetBool("isMoving", true);
        }
        else if(rb.velocity.x > 0)
        {
            facingRight = true;
            isIdle = false;
            AnimationFlipper();
            animator.SetBool("isMoving", true);
        }
        else if(rb.velocity.x == 0)
        {
            isIdle = true;
            animator.SetBool("isMoving", false);
        }

        if(updatePosY != initPosY)
        {
            updatePosY = initPosY;
            transform.position = new Vector2(transform.position.x, updatePosY);
        }
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Weapon")
        {
            health -= 1;
            Debug.Log("Health: " + health);
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void AnimationFlipper()
    {
        if(movingRight != facingRight && isIdle == false)
        {
            movingRight = !movingRight;
            Vector3 scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
        }
    }

}
