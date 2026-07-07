using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    public CharacterController characterController;
    public float gravity = -9.81f;
    public Vector3 velocity;
    public Animator animator;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * z;
        characterController.Move(move * moveSpeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
        bool isMoving = move.magnitude > 0.1f;
        animator.SetBool("Walking", isMoving);

        if(Mathf.Abs(x) > 0.1f)
        {
            float rotationAmount = x * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotationAmount, 0);
        }
    }
}
