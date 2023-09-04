using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    private bool isGrounded;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    private CollisionManager collisionManager;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        collisionManager = GetComponent<CollisionManager>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = collisionManager.groundCheck();
    }



    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        Vector3 upVec = transform.TransformDirection(Vector3.up);

        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);


        playerVelocity += upVec * gravity * Time.deltaTime;
        //this calculates what percentage of each entry in a vector is going towards a certain value
        // this vector will serve as the direction of gravity
        Vector3 gravityForceVector = Vector3.Project(playerVelocity, upVec);

        

        if (isGrounded && Vector3.Dot(gravityForceVector, upVec) < 0){

            playerVelocity = gravityForceVector.normalized * 2f; 

            //** This code will not work without a Rigid Body***
            // we then nomralize this so it can used as the constant gravitational force when grounded
            // Vector3 gravityWhenGrounded = gravityForceVector.normalized * 2f; 

            // We remove the the initialGravitional force and add a new one
            // playerVelocity = playerVelocity - gravityForceVector + gravityWhenGrounded;
        }

        Debug.Log(playerVelocity);        
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void jump(){
        if (isGrounded){
            float jumpVelocity = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
            Vector3 jumpDirection = transform.TransformDirection(Vector3.up);
            playerVelocity = jumpDirection * jumpVelocity;        
        }
    }

    public void shiftLeft(){
        transform.rotation = Quaternion.identity;
        transform.Rotate(Vector3.forward, 90f);
    }
    public void shiftRight(){
        transform.rotation = Quaternion.identity;        
        transform.Rotate(Vector3.forward, -90f);
    }

    public void shiftForward(){
        transform.rotation = Quaternion.identity;        
        transform.Rotate(Vector3.right, 90f);
    }

    public void shiftBackward(){
        transform.rotation = Quaternion.identity;        
        transform.Rotate(Vector3.right, -90f);
    }

    public void shiftUp(){
        transform.rotation = Quaternion.identity;        
    }

    public void shiftDown(){
        transform.rotation = Quaternion.identity;        
        transform.Rotate(Vector3.right, 180f);
        transform.Rotate(Vector3.up, 180f);
    }

}
