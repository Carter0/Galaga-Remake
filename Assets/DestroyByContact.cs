﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	
	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.tag == "Boundary")
		{
			return;
		}
	
		Destroy (other.gameObject);
		Destroy(transform.gameObject);
	}
}
