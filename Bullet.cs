﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Target" || other.gameObject.tag == "Ground")
        {
            print("target hit");
            Destroy(gameObject);
        }
    }
	
}
