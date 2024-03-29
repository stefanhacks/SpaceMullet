﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

	[Range (1, 10)]
	public int transitionSpeed = 1;

	[Range (1, 10)]
	public float mulletMass = 1;

	[Range (0, 1)]
	public float mulletPositionTreshold = 0.3f;

	[Range (1, 10)]
	public float accelerationForce = 1f;

	[Range (0.1f, 1f)]
	public float maxSwipeTime = 0.5f;

	[Range (50, 150)]
	public float minSwipeMagnitude = 50;

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

	[Range (3, 15)]
	public float spawnDistance = 3;

	[Range (5, 15)]
	public int maxPlanetPlayerOffset = 5;

	[Range (1, 15)]
	public float sectorScale = 1;

	[Range (1, 10)]
	public float controlForce = 5;

	[Range (0, 2)]
	public int minNOverlays = 1;

	[Range (2, 4)]
	public int maxNOverlays = 2;

	[Range (0, 4)]
	public int maxNRings = 2;

	[Range (0f, 100f)]
	public float chanceForWeirdOverlay = 5f;

	[Range (0f, 100f)]
	public float chanceForRing = 10f;

	[Range (0f, 100f)]
	public float chanceForWeirdPlanet = 5f;

	public bool devMode;
	public enum InputType { RotateLocal, PushHorizontal }
	public InputType currentInputType = InputType.RotateLocal;
	public Sprite mulletSpriteAstronaut, mulletSpriteCosmonaut, buttonPause, buttonRetry;
	public GameObject planetPrefab, sectorPrefab;

	private static GameSettings instance;

	void Start () {
		if (minGrav > maxGrav) {
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

	void Awake () {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
}
