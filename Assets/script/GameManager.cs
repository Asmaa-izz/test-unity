using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private int score = 0;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		Debug.Log ("the game start now !!");
		transform.Translate (pos);
	}

	public void setScore(int newscore)
	{
		score = newscore;
	}

	public int getScore()
	{
		return score;
	}

	void Update()
	{
		Debug.Log (score);

	}
}
