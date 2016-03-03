using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	private float c = 0;



	void Update ()
	{
		transform.position = new Vector2 (3 * Mathf.Sin (Time.time + c), 7);
	}
}
