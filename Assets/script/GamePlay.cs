using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour {
	public GameManager theManager;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			int s = theManager.getScore ();
			s++;
			theManager.setScore (s);

		}
	}
}
