using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	private PlayerControler player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControler> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Respawned");
		player.transform.position = currentCheckPoint.transform.position;
	}

}
