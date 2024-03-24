using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Vector2 movement;                   // this vector will store our position in the game (XY position)
    public float moveSpeedWalk = 5f;    // attribute for movement speed (this will be the speed of walk)
    public float moveSpeedRun = 10f; 
    public Rigidbody2D rb;

    private 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // FixedUpdate -> function to fix weird behaviour in update funciton. The reason for this is because our framerate can constantly change which makes physics unreliable. So in Update function will control the "input" and FixedUpdate will control the movement
    void Update()
    {
    /* 
     * Input.GetAxisRaw is used in order to get some input from a certain dimension. This is gonna give us a value between -1 and 1 (depending on our HORIZONTAL input, in this case).
     * If I press left arrow in the keyboard, this function will return -1 (negative movement in X axis). If i dont press anything at all will return 0.
     * This also works with W A S D.
     * THIS MAY NOT WORK. CHECK FOR NEW INPUT SYSTEM.
     */
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical"); 
    }
    void FixedUpdate()
    {
        /*
         * we use MovePosition function to move our rigid body rb (main character) to a new position. This new position will be our actual position (rb.position) + the new position (movement) * speed of the movement (moveSpeedWalk) * the time elapsed since we called this function (Time.fixedDeltaTime)
         */
        rb.MovePosition(rb.position + movement * moveSpeedWalk * Time.fixedDeltaTime);
    }
}
