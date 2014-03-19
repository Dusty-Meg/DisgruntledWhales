using UnityEngine;
using System.Collections;

public class left : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (-4, 3, -1.5f);
		Quaternion rot = new Quaternion (0, 0, 0, 0);
		transform.position = move;
		transform.rotation = rot;
	}
}
