using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_controller : MonoBehaviour {

    public float parallaxSpeed = 0.02f;
    public RawImage background;
    public RawImage platform1;
    public RawImage platform2;
    public RawImage platform3;
	public RawImage platform11;
	public RawImage platform21;
    public enum GameState { Idle, Playing };
	private GameState gameState = GameState.Idle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		//Empieza
		if ((Input.GetKeyDown ("up") || Input.GetMouseButtonDown (0))) {
			gameState = GameState.Playing;
		} else if (gameState == GameState.Playing) {
			parallax (background);
		}
	}
	void parallax (RawImage image){
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		image.uvRect = new Rect (image.uvRect.x + finalSpeed, 0f, 1f, 1f);
	}
}
