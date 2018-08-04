using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenadjust : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Camera.main.aspect = 800f / 480f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
