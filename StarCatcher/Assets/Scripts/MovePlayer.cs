using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public Transform playerArt;
    public Animator playerAnim;
    public Rigidbody player;
    public Vector3 tempPos;
    public float speed, speedDamper;
    public bool left;
    public float jumpForce, jumpCount, gravity;

	void Start () {
        playerAnim = GetComponentInChildren<Animator>();
        jumpForce *= 1000;
        StartCoroutine(PlayerMovement());
    }

    IEnumerator PlayerMovement() {
        Run(Input.GetAxis("Horizontal"));
        playerAnim.SetFloat("RunSpeed", Mathf.Abs(Input.GetAxis("Horizontal")));
        Jump(); // **ToDo**: find a way around the if statement
        transform.Translate(tempPos);
        yield return null;
        StartCoroutine(PlayerMovement());
    }

    void Run(float dir) {
        tempPos.x = dir * Time.deltaTime * speed; // ad speed damper as needed
        Rotate(dir);
        //transform.Translate(tempPos);
    }

    void Rotate(float dir)
    {
        if (dir > 0 && left)
        {
            Flip(false);
        }
        if (dir < 0 && !left)
        {
            Flip(true);
        }
    }

    void Flip(bool b) {
        //playerArt.localScale * new Vector3 (-1f, 0,0);
        playerArt.Rotate(0, 180, 0);
        left = b;
    }

    void Jump() {
        if (Input.GetButtonDown("Jump")){
            player.AddForce(0, jumpForce * jumpCount * Time.deltaTime, 0); //uses gravity and rigidbody
            jumpCount--;
        }
    }

    /*void JumpCall()   // Issues, reworking, player appears to teleport and gravity also drags the parent along through the world
    {
        tempPos.y = gravity * Time.deltaTime; //gravity 
        if (Input.GetButtonDown("Jump"))
        {
            Jumps();
        }
        //transform.Translate(tempPos);
        //Debug.Log(tempPos);
    }

    void Jumps()
    {
        tempPos.y += jumpForce * jumpCount * Time.deltaTime;
        jumpCount--;
    }*/

}
