using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    
    private CharacterController controller;
    float playerRadius;
    float halfPlayerHeight;
    float halfPlayerCylinderheight;


    void getPlayerDimensions(){
        playerRadius = controller.radius;
        halfPlayerHeight = controller.height / 2;
        halfPlayerCylinderheight = halfPlayerHeight - playerRadius;
    }
    void Start(){
        controller = GetComponent<CharacterController>();
        getPlayerDimensions();
    }

    public bool groundCheck(){
        /*
        Uses 5 points Raycasts to check the downward end of the cylinder. front, back, right, left and center.
        */
        float checkDist = .1f;
        Vector3 downVec = transform.TransformDirection(Vector3.down);
        Vector3 forwardVec = transform.TransformDirection(Vector3.forward) * playerRadius;
        Vector3 rightVec = transform.TransformDirection(Vector3.right) * playerRadius;
        Vector3 halfCylinderHeightVec = halfPlayerCylinderheight * downVec;
        Vector3 halfPlayerHeightVec = halfPlayerHeight * downVec;
        bool frontCheck = Physics.Raycast(transform.position + forwardVec + halfCylinderHeightVec, downVec * 1f, checkDist);
        bool backCheck = Physics.Raycast(transform.position + -forwardVec + halfCylinderHeightVec, downVec * 1f, checkDist);
        bool righCheck = Physics.Raycast(transform.position + rightVec + halfCylinderHeightVec, downVec * 1f, checkDist);
        bool leftCheck = Physics.Raycast(transform.position + -rightVec + halfCylinderHeightVec, downVec * 1f, checkDist);
        bool centerCheck = Physics.Raycast(transform.position + halfPlayerHeightVec, downVec * 1f, checkDist);

        if (frontCheck || backCheck || righCheck || leftCheck || centerCheck){
            return true;
        }

        return false;
    }


  
    void wallCheck() {
        // Approach ground check with using a ray through a RayCast
        float offsetVal = playerRadius + .01f;
        RaycastHit hitFront;
        Transform targetWall;
        bool frontCheck = Physics.Raycast(transform.position + (transform.forward * offsetVal), transform.forward * 1f, out hitFront, 1f);
        // hit will contain the distance so check if it corresponds to the object on plane
        targetWall = hitFront.transform;
        if (targetWall != null){
            // Debug.Log(targetWall.tag);
        }
    }

    void FixedUpdate(){
        wallCheck();
    }


    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }
}