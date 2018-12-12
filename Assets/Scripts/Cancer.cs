using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancer : MonoBehaviour 
{
	public void OnTriggerEnter(Collider other)
	{
		GameObject go = other.gameObject;
		if(go.tag == "Player" || go.tag == "MainCamera")
		{
			go.transform.position = new Vector3(38f, -45.5f, 13f);
		}
	}
}
