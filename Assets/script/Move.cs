using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 10f;
	public Color[] theColores;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}

	void move()
	{
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate (new Vector3 (0, speed, 0) * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (new Vector3 (0, -speed, 0)* Time.deltaTime);
		}


	}
}
