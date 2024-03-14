using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerFirstPerson : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    public float sprintSpeed = 10.0f;
    public float mouseSensitivity = 2.0f;
    public float jumpForce = 8.0f;
    private float verticalRotation = 0.0f;
    public float upDownRange = 60.0f;
    public Camera playerCam;
    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    private float gravity = 15f;
    public float moveSpeed = 0;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Input per il movimento orizzontale
        moveSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;
        float forwardSpeed = Input.GetAxis("Vertical") * moveSpeed;
        float strafeSpeed = Input.GetAxis("Horizontal") * moveSpeed;

        if (characterController.isGrounded)
        {

            moveDirection = new Vector3(strafeSpeed, 0, forwardSpeed);
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetAxisRaw("Jump") > 0)
            {
                moveDirection.y = jumpForce;

            }

        }
        else
        {
            // Mantieni la direzione orizzontale del movimento, ma applica la gravità
            moveDirection = new Vector3(strafeSpeed, moveDirection.y, forwardSpeed);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Applica la rotazione orizzontale basata sul movimento del mouse
        float rotX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotX, 0);

        // Applica la rotazione verticale basata sul movimento del mouse
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        playerCam.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Muove il personaggio
        characterController.Move(moveDirection * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Trap"))
        {

            SceneManager.LoadScene("BossFight");
        }
    }
}
