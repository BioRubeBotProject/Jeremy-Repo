using UnityEngine;
using System.Collections;

public class Transparent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color a = this.gameObject.GetComponent<Renderer> ().material.color;
		// ().material.color;
		a.a = 0.25f;
		
		this.gameObject.GetComponent<Renderer> ().material.color = a;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
