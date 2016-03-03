using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour 
{
	public GameObject Shot;
	public Transform shotspawn;
	public float firerate;
	private float nextfire;

	void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > nextfire)
		{
			nextfire = Time.time + firerate; 
			Instantiate (Shot, shotspawn.position, shotspawn.rotation);
		}
	}
}
