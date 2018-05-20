using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

	public GameManager gamemanage;

	public void RestartGame(){

		gamemanage.Reset ();
	}

	public void QuitToMain(){

		SceneManager.LoadScene (0);

	}
		

}
