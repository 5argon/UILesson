using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenuScreen : MonoBehaviour {

	public GameplayUIManager manager;

	public void GoToMenu()
	{
		StartCoroutine(GoToMenuRoutine());
	}

	IEnumerator GoToMenuRoutine()
	{
        manager.GoOutAll();
		//wait a bit so we can see the UI go out before switching scene...
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Menu");
	}

}
