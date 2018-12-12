using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour 
{
	public void OnTriggerEnter(Collider other)
	{
		GameObject go = other.gameObject;
		if(go.tag == "Player" || go.tag == "MainCamera")
		{
			go.transform.position = new Vector3(92.4f, 25f, 280.28f);

			GameObject[] FireToRemove = GameObject.FindGameObjectsWithTag("FireC");

			foreach(GameObject Fire in FireToRemove)
			{
				Destroy(Fire);
			}
		}
	}
}
