using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float sens = 100;
    public Transform player;

    float x, y, xRot, yRot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        Clamp();
        Rotation();
    }

    void MyInput()
    {
        x = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRot -= y;
        yRot += x;
    }

    void Clamp()
    {
        xRot = Mathf.Clamp(xRot, -90, 90);
        yRot = Mathf.Clamp(yRot, -90, 90);
    }

    void Rotation()
    {
        transform.localRotation = Quaternion.Euler(xRot, yRot, 0f);
    }
}
