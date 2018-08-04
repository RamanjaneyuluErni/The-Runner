using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TranslateScript : MonoBehaviour {

    public float speed;
	void Update () 
	{
		transform.Translate (new Vector3(-speed*Time.deltaTime,0,0));
	}

	public void OnTriggerEnter2D(Collider2D obj){
		if(gameObject.tag=="wolverine" && obj.gameObject.tag=="runner")
		{
			Destroy (obj.gameObject);
			StartCoroutine (spawn());
		}
	}

	IEnumerator spawn()
	{
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene("Menu Scene");

	}
}
