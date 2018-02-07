using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

    private SpriteRenderer _spriteRenderer;

	// Use this for initialization
    
    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
    // Update is called once per frame
    void Update ()
    {
     

        if (Input.GetKey(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.UpArrow)))
        {
            _spriteRenderer.flipY = true;
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.DownArrow)))
        {
            _spriteRenderer.flipY = true;
        }

        else
        {
            _spriteRenderer.flipY = false;
        } 

     
    }
}
