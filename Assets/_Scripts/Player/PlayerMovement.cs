using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 40f;
    [SerializeField] private Animator animator;

    private float horizMove = 0f;
    private bool isJumping = false;
    [SerializeField] private bool isCrouching = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizMove));

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            isCrouching = false;
        }
        Debug.Log(isCrouching);
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching()
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move the character
        controller.Move(horizMove * Time.fixedDeltaTime, isCrouching, isJumping);
        isJumping = false;

    }
}
