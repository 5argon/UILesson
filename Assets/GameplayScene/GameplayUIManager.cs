using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayUIManager : MonoBehaviour {

	public Animator lowerLeft;
	public Animator upperLeft;

    //All Animator has Triggers with same name
	//So this is convenient
	private const string comeInString = "ComeIn";
	private const string goOutString = "GoOut";

	void Start()
	{
		ComeInAll();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z))
		{
            //Don't press Z when it is already come in!
			//Trigger will not be consumed and will be stored. (Check in the Animator panel)
			ComeInAll();
		}
		if(Input.GetKeyDown(KeyCode.X))
		{
			GoOutAll();
		}
	}

	public void ComeInAll()
	{
        StopAllCoroutines();
		StartCoroutine(ComeInAllRoutine());
	}

	public void GoOutAll()
	{
        //I dont want sequences in GoOut, just disappear together.
		//Coroutine not needed here
        StopAllCoroutines();
		lowerLeft.SetTrigger(goOutString);
		upperLeft.SetTrigger(goOutString);
	}

	IEnumerator ComeInAllRoutine()
	{
		//With Coroutine, I can wait a bit, creating "UI animation sequence"
		lowerLeft.SetTrigger(comeInString);
		yield return new WaitForSeconds(0.4f);
		upperLeft.SetTrigger(comeInString);
	}

}
