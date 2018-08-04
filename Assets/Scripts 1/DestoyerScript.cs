using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestoyerScript : MonoBehaviour {

	public GameObject ex;
	public Text GameOver;
	void OnTriggerEnter2D(Collider2D obj)
	{
		int i=0;
		if (gameObject.tag == "sky") Destroy (obj.gameObject);
		else if(gameObject.tag == "runner")
		{
			if (obj.gameObject.tag == "apple" ||obj.gameObject.tag == "watermelon" || obj.gameObject.tag == "straberry") {
				   if (obj.gameObject.tag == "apple") i = 10;
				   else if (obj.gameObject.tag == "straberry") i = 5;
				   else if (obj.gameObject.tag == "watermelon") i = 15;
				   var s = ex.GetComponent<UImanager>();
				   s.instance.IncrementScore (i);
				   Destroy (obj.gameObject);
			   } 
			else if (obj.gameObject.tag == "wolverine" ) 
			{
				GameOver.text="Game Over!!";
			    
			}
		 }
	   }

}
