﻿using UnityEngine;
using System.Collections;

public class createprefab : MonoBehaviour {
public Transform BasicRoom;

void Start() {
	for (int y = 0; y < 5; y++) {
		for (int x = 0; x < 5; x++) {
			Instantiate(BasicRoom, new Vector3(x, y, 0), Quaternion.identity);
		}
	}
}


	
	// Update is called once per frame
	void Update () {
	
	}
}
