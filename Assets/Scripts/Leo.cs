using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leo : MonoBehaviour 
{
	public void OnTriggerEnter(Collider other)
	{
		GameObject go = other.gameObject;
		if(go.tag == "Player" || go.tag == "MainCamera")
		{
			GameObject[] FireToRemove = GameObject.FindGameObjectsWithTag("FireL");

			foreach(GameObject Fire in FireToRemove)
			{
				Destroy(Fire);
			}
		}
	}
}
