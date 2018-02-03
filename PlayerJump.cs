using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float jumpForce = 12f;
    public float jumpMultiplier = 3f;
    public float lowJumpMultiplier = 5f;

    public bool _grounded = false;
    public bool _isDucking = false;

    Rigidbody rigidB;
    BoxCollider boxC;

    void Awake()
    {
        rigidB = GetComponent<Rigidbody>();
        boxC = GetComponent<BoxCollider>();
    }

    void Update()
    {
        Duck();
        if (Input.GetButtonDown("Jump") && _grounded == true && _isDucking == false)
        {
            rigidB.velocity += Vector3.up * jumpForce;
            _grounded = false;
        }

        if (rigidB.velocity.y < 0)
        {
            rigidB.velocity += Vector3.up * Physics2D.gravity.y * (jumpMultiplier - 1) * Time.deltaTime;
        }
        else if (rigidB.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rigidB.velocity += Vector3.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && _grounded == true)
        {
            _isDucking = true;
        }
        else
        {
            _isDucking = false;
        }

    }

    void OnCollisionEnter (Collision coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            _grounded = true;
        }
        else
        {
            return;
        }

    }

    void Duck()
    {
        if (_isDucking == true)
        {
          //  boxC.enabled = false;
        }
        else
        {
           // boxC.enabled = true;
        }
    }



}