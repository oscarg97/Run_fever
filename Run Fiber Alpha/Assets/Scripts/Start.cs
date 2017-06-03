using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start : MonoBehaviour {
	public float parallaxSpeed = 0.02f;
	public RawImage background;
	public enum GameState { Idle, Playing };
	public GameState gameState = GameState.Idle;
	Game_controller gc = new Game_controller ();
	// Use this for initialization
	void Start1 () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		background.uvRect = new Rect (background.uvRect.x + finalSpeed, 0f, 1f, 1f);
		if (Input.GetKeyDown ("up") || Input.GetMouseButtonDown (0)) {
			gameState = GameState.Playing;
			
		} else if (gameState == GameState.Playing) {
			gc.Update ();
		}
	}
}
