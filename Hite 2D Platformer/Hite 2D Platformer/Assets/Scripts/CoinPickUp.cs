﻿using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour 
{

	public GameObject hero;

	public int pointsToAdd;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerControler> () == null)
			return;

			ScoreManager.AddPoints (pointsToAdd);

			Destroy (gameObject);
		
	}

}