using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	void Start()
	{
		Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}
}
