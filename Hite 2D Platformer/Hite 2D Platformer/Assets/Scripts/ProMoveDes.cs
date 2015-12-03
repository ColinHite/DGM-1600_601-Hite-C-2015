using UnityEngine;
using System.Collections;

public class ProMoveDes : MonoBehaviour {

	public int speed;
	public PlayerControler player;

	public GameObject enemyDeath;

	public GameObject projectileParticle;

	public int pointsForKill;

	void Start () 
	{
		player = FindObjectOfType<PlayerControler> ();

		if (player.transform.localScale.x < 0) 
		{
			speed = -speed;
		}
	}
	

	void Update () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "enemy") 
		{
			Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (pointsForKill);
		}
		Instantiate(projectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
