﻿using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	void Update () 
	{
		//Move Right
		if(Input.GetKey (KeyCode.D)){		
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

	}
		//Move Left
		if(Input.GetKey (KeyCode.A)){		
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
	
	}
		// Jump
		if(Input.GetKeyDown (KeyCode.Space)){		
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}
}