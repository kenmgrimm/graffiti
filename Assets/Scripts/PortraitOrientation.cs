﻿using UnityEngine;
using System.Collections;

public class PortraitOrientation : MonoBehaviour {
	void Start () {
		InvokeRepeating("UpdateOrientation", 0, 3);
	}

	private void UpdateOrientation() {
		Screen.orientation = ScreenOrientation.Portrait;
	}
}