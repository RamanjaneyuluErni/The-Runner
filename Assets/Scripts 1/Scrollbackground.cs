using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollbackground : MonoBehaviour {
	  
	public GameObject grounds;
	public float delay;
	public Vector3 pos;
	public float speed = 0.1f;
	void Start () {
	    pos = new Vector3 (17f, -3.97f, 0f);
		StartCoroutine (spawn());
		delay = 0.3f;
	}
	void Update () {
	
		Vector2 offset = new Vector2 (Time.time * speed, 0f);
		GetComponent<Renderer>().material.mainTextureOffset = offset;

	}

	IEnumerator spawn()
	{
		while (true) {
			Instantiate (grounds, pos, Quaternion.identity);
			yield return new WaitForSeconds (delay);
		}

	}

	}

