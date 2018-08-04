using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {


	public Button[] buttons;
	public Text aboutGame;
	public Text backtomenu;
	public Text displayHighScoretext;
	public Text instructionstext;
	public GameObject[] objects;
	public void menu()
	{
		SceneManager.LoadScene("Menu Scene");
	}
	public void NewGame()
	{
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} 
		SceneManager.LoadScene("GameScene");
	}
	public void Resume()
	{
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} 
		for (int i = 0; i < 4; i++) {
			buttons[i].gameObject.SetActive(true);
		}
		for (int i = 4; i < 7; i++) {
			buttons[i].gameObject.SetActive(false);
		}
	}
	public void pause(){

		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} 
		else if (Time.timeScale == 1) {
			Time.timeScale = 0; 
			for (int i = 0; i < 4; i++) {
				buttons[i].gameObject.SetActive(false);
			}
			for (int i = 4; i < 7; i++) {
				buttons[i].gameObject.SetActive(true);
			}
		}

	}
	public void ExitGame()
	{
		Application.Quit();
	}
	public void About()
	{
		for (int i = 0; i < 4; i++) {
			buttons [i].gameObject.SetActive (false);
		}
		buttons [4].gameObject.SetActive (true);
		for (int i = 0; i < 8; i++) {
		     objects[i].GetComponent<Renderer>().enabled = false;
		}
		aboutGame.text = "CONTROLS:                                                             " +
		"right arrow to move right side                                        " +
		"left arrow to move left side                                          " +
		"make use of jump button to jump                                       " +
		"SCORING:  apple :15 points                                            " +
		"          watermelon:10 points                                          " +
		"          strawberry :5 points                                         " +
		"          avoid falling in water and collinding with wolverine or else you will die" +
		"                                                                                    "+
	    "                                                               @Ramanjaneyulu Erni";
		backtomenu.text="Back";
		instructionstext.text="Instructions";
	}
	public void BackButton()
	{
		SceneManager.LoadScene("Menu Scene");
	}
	public void HighScoreButton()
	{
		for (int i = 0; i < 4; i++) {
			buttons [i].gameObject.SetActive (false);
		}
		buttons [4].gameObject.SetActive (true);
		for (int i = 0; i < 8; i++) {
			if(i==3)objects[i].GetComponent<Renderer>().enabled = true;
			else objects[i].GetComponent<Renderer>().enabled = false;
		}
		int HighScore;
		HighScore=PlayerPrefs.GetInt ("Variabletext");
		displayHighScoretext.text = "High Score " + HighScore.ToString ();
		backtomenu.text="Back";
	}
}
