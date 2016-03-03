using UnityEngine;
using System.Collections;

public class ShotMovement : MonoBehaviour 
{	
	public float speed; 
	void Update() {
		transform.Translate(Vector3.up * speed, Space.World);
	}
}	