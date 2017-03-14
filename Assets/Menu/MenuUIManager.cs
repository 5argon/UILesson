using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour {

	public Animator left;
	public Animator right;

    //All Animator has Triggers with same name
	//So this is convenient
	private const string comeInString = "ComeIn";
	private const string goOutString = "GoOut";

	void Start()
	{
		ComeInAll();
	}

	public void ComeInAll()
	{
        StopAllCoroutines();
		StartCoroutine(ComeInAllRoutine());
	}

	IEnumerator ComeInAllRoutine()
	{
		//With Coroutine, I can wait a bit, creating "Sequence"
		left.SetTrigger(comeInString);
		yield return new WaitForSeconds(0.4f);
		right.SetTrigger(comeInString);
	}

}
