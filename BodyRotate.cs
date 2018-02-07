using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyRotate : MonoBehaviour {


    private SpriteRenderer _spriteRenderer;

    // Use this for initialization

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            _spriteRenderer.flipX = true;
        }
        if (Input.GetKey("right"))
        {
            _spriteRenderer.flipX = false;
        }
    }
}
