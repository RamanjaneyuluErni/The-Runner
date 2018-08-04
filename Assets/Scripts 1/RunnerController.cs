using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RunnerController : MonoBehaviour {

	public float speed=2f;
	float delay;
	public bool Onground;
	void Start () {
		delay = 0.001f;
		Onground = true;
	}
	IEnumerator jump()
	{
		if (Onground == true) {
			float height = 0f;
			while (true) {
				height = height + 0.2f;
				if (height >= 5.6f ) break;
				transform.Translate (new Vector3 (0, 0.2f, 0));
				yield return new WaitForSeconds (delay);
				Onground = false;
				Debug.Log ("moving up");
				Debug.Log (height);
			}
			while (true) {
				height = height - 0.2f;
				if (height <= 0f) break;
				transform.Translate (new Vector3 (0, -0.2f, 0));
				yield return new WaitForSeconds (delay);
				Debug.Log ("moving Down");
				Debug.Log (height);
			}

		}
		if (transform.position.y <= -1.2f)
			Onground = true;
		Debug.Log (Onground);
	}

	public void jumpup()
	{
		if(Onground == true )StartCoroutine (jump ());
	}
	public void leftmove()
	{
		if (Onground == true ) {
			transform.Translate (new Vector3 (-1f, 0f, 0f));
		}
	}

	public void rightmove()
	{
		if (Onground == true ) {
			transform.Translate (new Vector3 (4f, 0f, 0f)*15f*Time.deltaTime);
		}
	}
		
}
