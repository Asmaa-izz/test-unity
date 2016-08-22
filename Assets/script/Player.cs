using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	Rigidbody2D thebox;
	public float power = 250f;
	int score = 0;
	public Text scoreee;
	// Use this for initialization
	void Start () {
		thebox = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
		{
			thebox.AddForce (Vector2.up * power);
			score++;
		}

		scoreee.text = score.ToString ();

	}


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Finish")
			Destroy (gameObject);

	}

}




