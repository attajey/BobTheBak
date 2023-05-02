using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 40f;

    private float horizMove = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    void Update()
    {
        horizMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            isCrouching = false;
        }
    }

    void FixedUpdate()
    {
        // Move the character
        controller.Move(horizMove * Time.fixedDeltaTime, isCrouching, isJumping);
        isJumping = false;
        
    }
}
