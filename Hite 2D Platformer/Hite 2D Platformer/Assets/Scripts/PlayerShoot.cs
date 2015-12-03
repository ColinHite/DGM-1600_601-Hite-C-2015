using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	public Transform firePoint;

	public GameObject projectile;


	void Start () 
	{
	
	}
	

	void Update () 
	{
	if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			Instantiate(projectile, firePoint.position, firePoint.rotation);
		}

	}
}
