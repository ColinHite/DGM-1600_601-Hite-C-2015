using UnityEngine;
using System.Collections;

public class DesPar : MonoBehaviour {


	//Destroys Non-Used Particles
	//
	//

	private ParticleSystem myParticleSystem;



	// Use this for initialization
	void Start () {
		myParticleSystem = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (myParticleSystem.isPlaying) 
			return;

			Destroy (gameObject);
	}
}
