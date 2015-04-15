﻿using UnityEngine;
using System.Collections;

public class holePlacement : MonoBehaviour {

	public Transform holeTransform;
	public SpriteRenderer holeRenderer;
	public Vector3 xPos;

	// Use this for initialization
	void Start () {
		holeTransform = this.transform;
		holeRenderer = gameObject.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (holeTransform.position.y > GameObject.Find ("MainCamera").GetComponent<ScreenSize> ().topBorder.y) {
			newPos();
			holeTransform.position = new Vector3 (xPos.x, GameObject.Find ("MainCamera").GetComponent<ScreenSize> ().bottomBorder.y, holeTransform.position.z);

		} else {
			holeTransform.position = new Vector3 (holeTransform.position.x, (holeTransform.position.y + 0.03f), holeTransform.position.z);
		}

	}

	void newPos()
	{
		float position;
		int width = (int)GameObject.Find ("MainCamera").GetComponent<ScreenSize> ().rightBorder.x;

		position = Random.Range (-width, width);
		print ("width is " + width);

		xPos = new Vector3(position, 1f, 1f);

		//xPos = GameObject.Find("MainCamera").GetComponent<Camera>().ScreenToWorldPoint(temp);
	}
}

