using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	bool mouse = false;
	float x, y;
	
	void OnMouseDown()
	{
		Debug.Log("Pressed left click.");
		mouse = true;
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}

	void OnMouseUp()
	{
		mouse = false;

		SpringJoint2D[] tester = GetComponents<SpringJoint2D> ();

		foreach(SpringJoint2D testr in tester)
		{

			testr.enabled = false;
		}
	}

	void Update()
	{
		if (mouse == true)
		{
			Debug.Log(Input.mousePosition);

			Vector2 move2 = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

			transform.position = (move2);

			Quaternion rot = new Quaternion (0, 0, 0, 0);
			transform.rotation = rot;
		}
	}

}
