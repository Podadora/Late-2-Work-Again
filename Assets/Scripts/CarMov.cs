using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour {

	public float CarSpeed = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//gameObject.transform.Translate (0 , 0 ,CarSpeed);
		
	}

	void OnTriggerEnter(Collider Otro)
	{
		Debug.Log ("exit");

		if (Otro.tag =="StreetEnd")
		{
			Destroy (gameObject);
		}
	}
}
