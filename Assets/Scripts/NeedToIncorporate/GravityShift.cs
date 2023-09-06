using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: https://docs.unity3d.com/ScriptReference/Physics.Raycast.html

public class GravityShift : MonoBehaviour
{
    // The wall that the player will gravity shift to
    Transform targetWall;
    private Rigidbody rb;
    // Raycasts for checking the player's proximity to any walls behind and in front of them
    private RaycastHit hitFront;
    private RaycastHit hitBack;
    // Access the PlayerMove script for functions to access each axis's state
    public PlayerMove pm;
    // Specify which direction that gravity is exerted on the player
    private Vector3 orientVec;

    // An array of vectors that store the different directions that gravity can be exerted on the player
    private Vector3[] refVecs = { Vector3.down, Vector3.forward, Vector3.left, Vector3.right, Vector3.back, Vector3.up };
    public Transform vCamera;

    void Start()
    {
        orientVec = Vector3.down;
        rb = GetComponent<Rigidbody>();
    }

    // Helper function to specify the current gravity force for other scripts
    public Vector3 getOrientation()
    {
        return orientVec;
    }

    // Function to check if a player is close enough to a wall to perform the gravity shift.
    bool WallCheck()
    {
        // Approach ground check with using a ray through a RayCast
        float offsetVal = 0.6f;
        // Create 2 raycasts to check for the wall (front) and the player has enough space to rotate (back) as in not collide with a back wall when gravity shifting
        bool frontCheck = Physics.Raycast(transform.position + (transform.forward * offsetVal), transform.forward * 1f, out hitFront, 2f);
        bool backCheck = Physics.Raycast(transform.position - (transform.forward * offsetVal), transform.forward * -1f, out hitBack, 2f);
        // Verify that the raycasts was a success and then create a reference to the targeted wall
        if (frontCheck && !backCheck)
        {
            targetWall = hitFront.transform;
            return true;
        }
        else
            return false;
    }

    // Function responsible for the gravity shift
    // Uses a locki mechanism so player's can't accidently interfere with the process
    void changeGravity()
    {
        pm.keyLock();
        // Variables to indicate which axises are going to be used for horizontal or vertical movement
        bool xUsed = false;
        bool yUsed = false;
        bool zUsed = false;
        /*Set Vertical Axis 
        1. The currently unused axis now becomes the new vertical axis

        2. This unused axis tends to be the same as the non-zero value of the current gravity direction vector

        3. Use some algebra to properly set the axis state number for the new vertical axis
        */
        if (orientVec.x != 0)
        {
            pm.setAxisState(0, ((int)(orientVec.x * 0.5 + 2.5)));
            xUsed = true;
        }
        else if (orientVec.y != 0)
        {
            pm.setAxisState(1, ((int)(orientVec.y * 0.5 + 2.5)));
            yUsed = true;
        }
        else if (orientVec.z != 0)
        {
            pm.setAxisState(2, ((int)(orientVec.z * 0.5 + 2.5)));
            zUsed = true;
        }

        /* 
        Set Horizontal Axis 

        1. Calculate the distance between the player model's forward vector (where they are facing) to each of the 
        potential gravity direction vectors (refVecs)

        2. Store those values in an array (compareVecDist). The index corresponds to the index for refVec
        ex. compareVecDist[0] indicates refVecs[0] or vector3.down's distance from transform.forward

        3. Find the minimum vector out of the array, this indicates the new gravity direction vector because the new gravity direction vector 
        will  resemble the current player model's forward vector the most. 
        
        Ex. player facing right on the main surface with vector3.down as the current vector, so the transform.forward vector
        will most resemble vector3.right. That means they are facing the right wall and if they perform a gravity shift, then vector3.right will become the new
        gravity direction. Using the specific compareVecDist value follows this idea when performing the cross 
        product to determine horizontal movement on the new surface
        */

        // 1. 
        float[] compareVecDist = new float[6];
        int index = 0;
        for (int i = 0; i < 6; i++)
        {
            // 2.
            compareVecDist[i] = (refVecs[i] - transform.forward).sqrMagnitude;
        }
        // 3.
        for (int i = 1; i < 6; i++)
        {
            if (compareVecDist[i] < compareVecDist[index])
                index = i;
        }

        // Use cross product between the inverse of the current gravity direction and the new gravity direction
        // This will output a vector with 3 values, two of which will equal 0 and the third value will equal -1 or 1
        // And this indicates which axis will be responsible for horizontal movement and whether moving right causes a decrease 
        // or increase in that axis value. 
        Vector3 rightMov = Vector3.Cross(-1 * orientVec, refVecs[index]);

        // From there, it is a matter of finding which vector axis is the non-zero.
        // Then algebra is used to calculate the correct state number
        if (rightMov.x != 0)
        {
            pm.setAxisState(0, ((int)(rightMov.x * -0.5 + 0.5)));
            xUsed = true;
        }
        else if (rightMov.y != 0)
        {
            pm.setAxisState(1, ((int)(rightMov.y * -0.5 + 0.5)));
            yUsed = true;
        }
        else if (rightMov.z != 0)
        {
            pm.setAxisState(2, ((int)(rightMov.z * -0.5 + 0.5)));
            zUsed = true;
        }

        // Respond to the remaining axis that isn't used (enable rotation on this axis and specify its state as unused)
        if (!xUsed)
        {
            pm.setAxisState(0, 4);
        }
        else if (!yUsed)
        {
            pm.setAxisState(1, 4);
        }

        else if (!zUsed)
        {
            pm.setAxisState(2, 4);
        }

        // Update the current gravity direction
        orientVec = refVecs[index];
        pm.keyUnlock();
        // Move the player to allow the gravity shift to occur successfully
        pm.pushMov();
    }


    // Update responds to the gravity shift command
    void Update()
    {
        //Debug.DrawRay(transform.position + (transform.forward * offsetVal), transform.forward * 2f, Color.red);
        //Debug.DrawRay(transform.position - (transform.forward * offsetVal), transform.forward * -2f, Color.red);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Verify that the player satisfies their position in regard to walls and that they are grounded
            if (WallCheck() && !pm.GroundCheck())
            {
                changeGravity();
            }
            else
            {
                Debug.Log("Can't rotate");
            }
        }
    }
}
