﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour {

	private GameObject planet;

	void Start () {
		planet = this.transform.parent.gameObject;
	}

	void OnTriggerStay2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player")
			planet.GetComponent<Planet> ().SomethingInOrbit (coll.gameObject);
	}

	public void SetOrbit (float newO) {
		GetComponent<CircleCollider2D> ().transform.localScale = new Vector3 (newO, newO, 1);
	}
}
