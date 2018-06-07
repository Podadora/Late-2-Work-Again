using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteler : MonoBehaviour {
	private GameObject Ref;
	private Transform Ref1;
	// Use this for initialization
	void Start () {
		Ref = GameObject.FindGameObjectWithTag ("Player");

		
	}
	
	// Update is called once per frame
	void Update () {
		Ref1 = Ref.GetComponent<Transform> ();
		transform.position = new Vector3 (Ref1.transform.position.x, Ref1.transform.position.y, Ref1.transform.position.z -4);
	}
}
