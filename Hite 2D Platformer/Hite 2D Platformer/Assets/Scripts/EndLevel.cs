using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

	//Screen Overlay Object
	public GameObject win;
	

	//Finds the player to complete the level.
	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.gameObject.tag == "Player") 
		{

			win.SetActive(true);

		}

	}
}
