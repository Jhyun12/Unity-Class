using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 1.0f;
    public float mouseSpeed = 100.0f;

    float mX = 0.0f;
    float mY = 0.0f;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
    }

 

    void Update()
    {
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
      

        Vector3 direction = new Vector3(x, 0, z);

        characterController.Move(direction.normalized * speed * Time.deltaTime);

        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime, 0, Space.World);

    }
}