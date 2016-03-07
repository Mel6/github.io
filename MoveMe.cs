using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {

	public Vector3 speed = new Vector3 (0f,0f,0f);
	public GameObject [] moveables;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		Debug.Log (GetComponent<Transform> ().position);

		GetComponent<Transform> ().position += speed;
		transform.Translate (speed);


		foreach (GameObject Sphere in moveables) {
			Sphere.transform.Translate (speed);
		}
	}
}