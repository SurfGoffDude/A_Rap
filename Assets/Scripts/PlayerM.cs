using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] private float speed = 4;
    [SerializeField] private float jumpf = 10;
    private int jumpKol = 0;
    [SerializeField] int maxJumps = 2;

    private Animator animator;
    private Rigidbody2D rigidBody2D;
    private isGround ground = null;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        ground = GetComponentInChildren<isGround>();

    }
    private bool doJump = false;

    // Update is called once per frame
    void Update()
    {
        doJump |= Input.GetButtonDown("Jump") && jumpKol < maxJumps;
    }

    private void FixedUpdate()
    {
        Vector2 motion = rb.velocity;
        
        if (doJump)
        {
            doJump = false;
            motion.y = jumpf;
            jumpKol += 1;
            animator.SetBool("isJumping", true);
            Debug.Log($"b");
        } else
        {
            animator.SetBool("isJumping", false);
        }

        if (ground.isGrnd())
        {
            jumpKol = 0;
        }

        var input = Input.GetAxis("Horizontal");
        if (input == 0)
        {
            animator.SetBool("isWalking", false);
            motion.x = rb.velocity.x;
        }
        else
        {
            var scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x) * Mathf.Sign(input);
            transform.localScale = scale;

            animator.SetBool("isWalking", true);
            motion.x = input * speed;
            
        }
        
        rb.velocity = motion;
    }
}


