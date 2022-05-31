﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualEffectsMenuScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClicked(int index) {
		if (index == 0) {
            LoadManager.Instance.LoadScene(SceneNames.BASIC_LIGHTING_SCENE);
		}

		if (index == 1) {
			LoadManager.Instance.LoadScene (SceneNames.REALTIME_LIGHTING_SCENE);
		}

		if (index == 2) {
			LoadManager.Instance.LoadScene (SceneNames.BAKED_LIGHTING_SCENE);
		}

		if (index == 3) {
			LoadManager.Instance.LoadScene (SceneNames.MAIN_SCENE);
		}
	}
}
