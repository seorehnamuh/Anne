using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFirstPerson : MonoBehaviour
{
    public float walkSpeed = 5.0f; // Velocit� di movimento normale
    public float sprintSpeed = 10.0f; // Velocit� di sprint
    public float mouseSensitivity = 2.0f; // Sensibilit� del mouse
    private float verticalRotation = 0.0f;
    public float upDownRange = 60.0f; // Limite di inclinazione su/gi� della visuale
    public Camera playerCam;
    private CharacterController characterController;
    public GameObject Prefab;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; // Nasconde il cursore del mouse e lo blocca al centro dello schermo
    }

    private void Update()
    {
        // Input per il movimento
        float moveSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;
        float forwardSpeed = Input.GetAxis("Vertical") * moveSpeed;
        float strafeSpeed = Input.GetAxis("Horizontal") * moveSpeed;

        Vector3 speed = new Vector3(strafeSpeed, 0, forwardSpeed);

        // Applica la rotazione orizzontale basata sul movimento del mouse
        float rotX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotX, 0);

        // Applica la rotazione verticale basata sul movimento del mouse
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        playerCam.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Applica il movimento verticale della camera basato sul movimento del mouse
        float rotY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        playerCam.transform.Rotate(rotY, 0, 0);

        // Applica la gravit�
        if (characterController.isGrounded)
        {
            speed.y = 0;
        }
        else
        {
            speed.y -= 9.8f; // Gravit� costante
        }

        // Muove il personaggio in base alla velocit�
        Vector3 moveDirection = transform.TransformDirection(speed);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
