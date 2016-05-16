using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed = 1f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) //Player moves left
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (KeyCode.RightArrow)) //Player moves right
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (KeyCode.UpArrow)) //Player moves up
			transform.Translate ((Vector3.forward) * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow)) //Player moves down
			transform.Translate ((Vector3.back) * speed * Time.deltaTime);
	}
}
