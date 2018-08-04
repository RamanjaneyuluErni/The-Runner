using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class generator : MonoBehaviour {

	public GameObject[] food;
	void Start () {
		StartCoroutine ("Coroutine");

	}
	IEnumerator Coroutine ()
	{
		while (true) {
			spawn();
			yield return new WaitForSeconds(3f);
		}


	}
	void spawn()
	{
		float height = 0f;
		int getvalue = Random.Range (0,5);
		if (getvalue == 3) {
			height = -3.93f;
		} else if (getvalue == 4) {
			height = -1.56f;
		}
		else 
		{
		   int getpos = Random.Range (0, 3);
		   switch (getpos)
		    {
			case 0:
				height = -1.0f;
				break;
			 case 1:
				height = 1.85f;
				break;
			 case 2:
				height = 3.8f;
				break;
			}
		}
		Vector3 pos = new Vector3 (25f,height, 0f);
		Instantiate (food[getvalue],pos,Quaternion.identity);
	}


}
