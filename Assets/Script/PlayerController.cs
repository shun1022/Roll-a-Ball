using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;

	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Rigidbody RigidBody = GetComponent<Rigidbody> ();

        RigidBody.AddForce (x *speed, 0, z *speed);

	}

}
