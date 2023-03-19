using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    float mouseX, mouseY;

    float rotateX, rotateY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotateY += mouseX;
        rotateX -= mouseY;

        transform.eulerAngles += new Vector3(-mouseY * mouseSensitivity, mouseX * mouseSensitivity, 0);
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotateX, rotateY, 0);

    }
}
