using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    /*public Transform player;
    //private Vector3 tempPos;
    public Rigidbody rb;
    public float jumpForce, jumpCount;
    public float gravity;

	void Start () {
	    
	}

    /*void Update()
    {
        tempPos.y = gravity * Time.deltaTime; //gravity 
        if (Input.GetButtonDown("Jump")){
            Jumps();
        }
        transform.Translate(tempPos);
        Debug.Log(tempPos);
    }

    void Jumps() {
        tempPos.y = jumpForce * jumpCount * Time.deltaTime;
        jumpCount--;
    }*/



    //** Reworking **
	
    //player seems to teleport up to the apex of his jump before falling back down

	/*void Update () {
        //Jump(Input.GetButtonDown("Space"));   //unable to use as a float, needs a if statement if its a bool trying to avoid
        tempPos.y = gravity * Time.deltaTime; //gravity  **currently having issues
        Jumps(Input.GetAxis("Vertical"));
        transform.Translate(tempPos);
        Debug.Log(tempPos);
    }

    void Jumps(float up) {
        tempPos.y += jumpForce * up * jumpCount * Time.deltaTime;
        //jumpCount--;
    }*/
}
