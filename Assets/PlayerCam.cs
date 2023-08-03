using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{


    public float sesitivityX;
    public float sesitivityY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor'un ortada olmasini sagliyoruz.
        Cursor.lockState = CursorLockMode.Locked;

        // cursor'un gorunurlugunu falseliyoruz
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse inputunu getir
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sesitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") + Time.deltaTime * sesitivityY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90f);

        // rotate cam and orientation

        transform.rotation = Quaternion.Euler(xRotation , yRotation , 0);
        orientation.rotation = Quaternion.Euler(0 , yRotation , 0);


    }
}
