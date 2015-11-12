using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	private PlayerControler player;

	//Particle System Var.
	public GameObject deathParticle;
	public GameObject respawnParticle;

	//stops renderer
	public float respawnDelay;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControler> ();
	}

	void Update () {
	
	}

	public void RespawnPlayer()
	{
		StartCoroutine ("RespawnPlayerCo");
	}


	public IEnumerator RespawnPlayerCo()
	{
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		Debug.Log ("Player Respawned");
		yield return new WaitForSeconds (respawnDelay);
		player.transform.position = currentCheckPoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer> ().enabled = true;
		Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
	}
}
