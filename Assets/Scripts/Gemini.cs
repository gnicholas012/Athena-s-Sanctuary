using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemini : MonoBehaviour
{
//	public int counter = 2;

	public void OnTriggerEnter(Collider other)
	{
		GameObject go = other.gameObject;
		if(go.tag == "Player" || go.tag == "MainCamera")
		{
/*			if(counter > 1)
			{
				print("old: " + go.transform.rotation);
				go.transform.rotation *= Quaternion.Euler(0,180f,0);
				print("new: " + go.transform.rotation);
				counter--;
				print("counter: " + counter);
			}
			else
			{
*/
				GameObject[] FireToRemove = GameObject.FindGameObjectsWithTag("FireG");

				foreach(GameObject Fire in FireToRemove)
				{
					Destroy(Fire);
				}
//			}
		}
	}
}
