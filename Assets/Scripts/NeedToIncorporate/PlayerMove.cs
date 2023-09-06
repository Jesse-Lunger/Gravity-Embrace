using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
Terminonology:

Gravity Shift: When the player shifts between walls or surfaces to cause the new wall/surface to be the floor of the player
Gravity Force: The player uses left-control to alter their mass and amplify the downward gravity force exerted on them

*/


public class PlayerMove : MonoBehaviour
{

    private Rigidbody rb;
    // 
    public float movSpd = 1f;
    public float groundSpd = 10f;
    // Default/normal gravity amount to exert on the player
    public float gravity = 5f;
    // The amount of gravity currently exerted on the player
    private float gravityAmt = 0f;

    // Base speed value to move the player when in mid air
    public float airSpd = 2f;

    // Speed value for rotating the player when moving
    public float turnSpd = 1f;
    // Jump height for the player when jumping
    public float jumpHeight = 10f;
    // Global vector used to store movement values along the x, y, and z axis and use to move the player
    Vector3 movVec;

    // Vector to indicate direction of where gravity is aimed towards
    private Vector3 orientVec = Vector3.down;
    // GravityShift script used to access the current gravity vector direction (which also gets altered there during a gravity shift)
    public GravityShift gs;
    // Bools are states used to initate a sequence of code
    private bool doJump = false; // Activate jump state
    private bool stopJump = false; // Reverse jump state's effects on player
    private bool startTimer = false; // Activate timer
    // Toggle gravity force state
    private bool doForce = false;

    // The amount of time the player is given for each variable jumo
    public float jumpTimer = 0.5f;
    // The current time remaining for a variable jump
    private float timer = 0f;
    // The altered mass value of the player when using gravity force
    public float forceMass = 1;
    // A value to determine how much force should be multiplied when exerting gravity on the player
    private float forceFact = 1f;
    // The player's default/normal mass amount
    private float norMass;

    private bool key = true;
    public Transform vCamera;
    private bool shiftCamera = false;

    /*
    axisState[] is an array used to decide the player's movement in regards to the world's axis values.
    Since the player can walk on walls, it changes how the player moves along the 3 axises with the controls.
    To keep track of which axises and direction (+ or -), each index of the array corresponds to the three axises (x, y, and z)
    and have a value 0-4 to indicate how that axis moves.

    Indexes
    0 = Correspond to the x axis
    1 = Correspond to the y axis
    2 = Correspond to the z axis

    Values
    0 = the player's position increases in axis value when the player presses up (Horizontal movement).
    1 = the player's position decreases in axis value when the player presses right (Horizontal movement).
    2 = the player's position increases in axis value when the player presses up (Vertical movement).
    3 = the player's position decreases in axis value when the player presses right (Vertical movement).
    4 = the axis is not in used

    */
    private int[] axisState;

    /*
    axisFreezeRot is an array used to monitor which axises can NOT rotate when on a specific surface.
    
    Indexes
    0 = Correspond to the x axis
    1 = Correspond to the y axis
    2 = Correspond to the z axis

    Values
    True = That axis will not rotate
    False = That axis can rotate

    */
    private bool[] axisFreezeRot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        norMass = rb.mass;
        gravityAmt = gravity;
        timer = jumpTimer;
        orientVec = gs.getOrientation();
        axisState = new int[3];
        axisState[0] = 0;
        axisState[1] = 4;
        axisState[2] = 2;
        axisFreezeRot = new bool[3];
        axisFreezeRot[0] = true;
        axisFreezeRot[1] = false;
        axisFreezeRot[2] = true;
    }

    // A small function for the player to move vertically (away from a wall) right after a gravity shift
    // Also invokes the rotation of the camera
    public void pushMov()
    {
        movVec = orientMove(0f, 0.1f);
        shiftCamera = true;
    }

    // Unity's input system to allow the player to move in 3D space
    public void OnMove(InputValue input)
    {
        // Get the left, right, up, and down movement through a 2D vector
        Vector2 inputVec = input.Get<Vector2>();

        // Get how the 2D Vector translates to walking on the current 3D terrain through orientMove()
        // fixedUpdate() uses the saved movVec to make the player move
        movVec = orientMove(inputVec.x, inputVec.y);

    }

    // A function for setting the player's state and ability to rotate on a particular axis
    public void setAxisState(int index, int state)
    {
        // Set the state for the axis from the input
        axisState[index] = state;
        // If the axis is not in used, then the player can be rotated on that axis, otherwise the rotation is disabled
        if (state == 4)
            axisFreezeRot[index] = false;
        else
            axisFreezeRot[index] = true;
    }

    // Lock Mechanism functions
    public void keyLock()
    {
        key = false;
    }
    public void keyUnlock()
    {
        key = true;
    }

    // Used to determine the axis
    private float readAxisState(int axisStateNum, float movHor, float movVer)
    {
        if (axisStateNum == 0)
            return movHor;
        else if (axisStateNum == 1)
            return -movHor;
        else if (axisStateNum == 2)
            return movVer;
        else if (axisStateNum == 3)
            return -movVer;
        else // axisStateNum == 4
            return 0f;
    }

    // A function to output the player's movement in a 3d vector in regards to their current surface and how it
    // is affected by their orientation.
    // Each readAxisState() call accesses each axis's state and determines how horizontal and vertical movement are decided
    // All of the movements are stored into one 3D vector that is returned
    Vector3 orientMove(float movHor, float movVer)
    {
        float x = readAxisState(axisState[0], movHor, movVer);
        float y = readAxisState(axisState[1], movHor, movVer);
        float z = readAxisState(axisState[2], movHor, movVer);
        return new Vector3(x, y, z);
    }

    // A function to test whether the player is on the ground or not with a raycast (needs work)
    public bool GroundCheck()
    {
        // Approach ground check with using a ray through a RayCast
        RaycastHit hit;
        bool groundTest = Physics.Raycast(transform.position + (orientVec * -1), orientVec, out hit, 1.13f);
        if (groundTest)
            return true;
        else
            return false;
    }

    // The jump has the player's gravity at zero to smoothly add upward force (relative to surface)
    void performJump()
    {
        gravityAmt = 0f;
        rb.AddForce(orientVec * -1 * jumpHeight, ForceMode.Impulse);
    }
    // The jump is done so the gravity goes back to normal to begin dragging the player down
    void releaseJump()
    {
        gravityAmt = gravity;
    }

    // Allow the player to do variable jumping (height varies based on button held duration)
    void jump()
    {
        // Initiate the jump
        if (Input.GetKeyDown(KeyCode.Space))
            doJump = true;
        // End the jump
        if (Input.GetKeyUp(KeyCode.Space))
            stopJump = true;
        // Use a timer to allow the jump to continue and disable the jump height inecrease when timer is done
        if (startTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
                stopJump = true;
        }
    }
    // Hold Left Control to allow the player to intensify their gravity (amplfy it) to exert strong downward forces on objects
    void forceGravity()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            doForce = true;
        if (Input.GetKeyUp(KeyCode.LeftControl))
            doForce = false;
    }

    // Update() is in charge of responding to player's special actions (jumps and gravity force)
    void Update()
    {
        // Read jump input
        jump();
        // Read gravity force input
        forceGravity();
    }

    // FixedUpdate() It is in charge of operating the game loop of moving the player in accordance to inputs
    void FixedUpdate()
    {
        // Key serves as a locking mechanism in events of not interfering with gravity shifting
        if (key)
        {

            // This section alters how the player moves and whether on the ground or in the air
            // Ideally, the player has less mobility mid-air (similar to real life)
            bool isGround = GroundCheck();
            float modSpd = 0f;
            if (isGround)
                modSpd = groundSpd;
            else
                modSpd = airSpd;
            rb.AddForce(movVec * movSpd * modSpd * rb.mass * forceFact);

            // Make sure the orientation is up-to-date with the current gravity
            orientVec = gs.getOrientation();
            // The player should rotate towards the direction of their movement when moving
            if (movVec != Vector3.zero)
            {
                Quaternion newRot = Quaternion.LookRotation(movVec, orientVec * -1);
                transform.rotation = newRot;
            }

            // During a gravity shift, the camera that is following the player needs to rotate to match the player's new orientation (rotation)
            if (shiftCamera)
            {
                //Using .Euler() to match the player's rotation to allow the camera to view them from the back and depict the player in an upright position
                vCamera.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
                shiftCamera = false;
            }
            // The jump signal is detected, so the player performs the initial jump and starts the variable timer
            if (doJump && isGround)
            {
                performJump();
                startTimer = true;
                doJump = false;
            }
            // The player has let go of the jump button, so the timer is resetted and disabled
            if (stopJump)
            {
                releaseJump();
                timer = jumpTimer;
                startTimer = false;
                stopJump = false;
            }
            // The gravity force command is read and the player's mass increases with more gravity force exerted on them
            if (doForce)
            {
                forceFact = 1.7f;
                rb.mass = forceMass;
                rb.AddForce(orientVec * gravity * forceMass * 3);
                //doForce = false;
            }
            // The gravity force command is not active so the player's mass and force remain at the default
            if (!doForce)
            {
                forceFact = 1f;
                rb.mass = norMass;
            }
            // Gravity of the current terrain exerts on the player
            rb.AddForce(orientVec * gravityAmt);
        }
    }


}
