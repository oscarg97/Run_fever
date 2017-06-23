﻿using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject[] obj;
	public float tiempoMin = 1.25f;
	public float tiempoMAx = 2.5f;

	// Use this for initialization
	void Start () {
		Generar ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//orden entre  
	void Generar (){
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMAx));
	}
}
