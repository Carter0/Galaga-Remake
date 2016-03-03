using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour 
{
	[System.Serializable]
	public class Boundary
	{
		public float xMin, xMax;
	}

	// Variables
	private float moveHorizontal;
	public float speed; 
	public Rigidbody2D rb;
	public Boundary boundary; 

	void Awake()
	{
		//rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called every application of physics
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);
		rb.velocity = movement * speed;
		rb.position = new Vector2 (Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 0.0f);



	}
}
