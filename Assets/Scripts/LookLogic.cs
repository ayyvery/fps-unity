using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookLogic : MonoBehaviour
{ 

    public float sensitivity = 1000f;

    public Transform character;

    public float vertical = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        vertical = vertical - mouseY;
        vertical = Mathf.Clamp(vertical, -80f, 90f);

        character.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(vertical, 0f, 0f);
    }
}
