using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5;
    private  Rigidbody theRigidbody;
    private Animator ani;

	// Use this for initialization
	void Start () {
        theRigidbody = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right"))
        {
            transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);
           
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);
            ani.SetBool("IsWalking", true);
        }

        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            ani.SetBool("IsWalking", true);
        }

       

        if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            ani.SetBool("IsWalking", false);
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            moveSpeed = 0;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            moveSpeed = 5;
        }
        
    }

}
