using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {


	int BurgersEatin = 3;


	void Start () {
		while (BurgersEatin > 0) {
			Debug.Log ("I've have eatin a burger.");
			BurgersEatin--;
		}
	}
}
