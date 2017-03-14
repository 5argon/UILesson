using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameplay : MonoBehaviour {

	public void GoToGameplayGoGo()
	{
		SceneManager.LoadScene("GameplayScene");
	}

}
