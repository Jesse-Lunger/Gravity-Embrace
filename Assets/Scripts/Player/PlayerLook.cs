using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;


    public void ProcessLook(Vector2 input){
        float mouseX = input.x;
        float mouseY = input.y;

        // allows camera to look Vertically
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;

        // prevents player from looking past vertical
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // rotates just the camera on the y axis, Not entire player
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // rotates entire player on the x axis.
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);

    }

}
