﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

	[Range (1, 10)]
	public float mulletMass = 1;

	[Range (0, 1)]
	public float mulletPositionTreshold = 0.3f;

	[Range (1, 10)]
	public float accelerationForce = 1f;

	[Range (1, 100)]
	public float minGrav = 2;

	[Range (1, 100)]
	public float maxGrav = 10;

	[Range (0.01f, 30)]
	public float minOrbit = 15;

	[Range (0.01f, 30)]
	public float maxOrbit = 30;

	[Range (1, 10)]
	public float minScale = 1;

	[Range (1, 10)]
	public float maxScale = 2;

	public bool devMode;
	public enum InputType { RotateLocal, PushHorizontal }
	public InputType currentInputType = InputType.RotateLocal;

	public Sprite mulletSpriteAstronaut, mulletSpriteCosmonaut;

	void Start () {
		if (minGrav > maxGrav ) {
			Debug.Log ("minGravitationForce > maxGravitationForce");
			Application.Quit ();
		}

		if (minOrbit > maxOrbit) {
			Debug.Log ("minObit > maxOrbit");
			Application.Quit ();
		}

		if (minScale > maxScale) {
			Debug.Log ("minScale > maxScale");
			Application.Quit ();
		}
	}
}
