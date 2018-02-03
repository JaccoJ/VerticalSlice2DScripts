using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


    public static int health;
    Text text;
	
    void Awake()
    {
        text = GetComponent<Text>();
        health = 3;
    }

	// Update is called once per frame
	void Update () {
        text.text = "[HP. " + health + "]";
	}
}
