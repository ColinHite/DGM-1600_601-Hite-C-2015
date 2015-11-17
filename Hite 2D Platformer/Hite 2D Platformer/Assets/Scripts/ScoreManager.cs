﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;
	//public GUIText text;
	Text text;

	void Start () 
	{
		text = GetComponent <Text> ();

		score = 0;
	}

	void Update () 
	{
	if (score < 0)
		score = 0;

		text.text = "Score: " + score;
	}

	public static void AddPoints (int pointsToAdd)
	{
		score += pointsToAdd;
	}

	public static void Reset ()
	{
		score = 0;
	}
}
