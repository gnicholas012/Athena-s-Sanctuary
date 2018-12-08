using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemini : MonoBehaviour
{
	public int counter = 2;

	public void OnTriggerEnter(Collider other)
	{
		GameObject go = other.gameObject;
		print(go.tag + " found");
		if(go.tag == "Player" || go.tag == "MainCamera")
		{
			print("player colided");
			if(counter > 1)
			{
				go.transform.Rotate(new Vector3 (0, 180, 0), Space.World);
				counter--;
				print("counter: " + counter);
			}
			else
			{

			}
		}
	}
}
