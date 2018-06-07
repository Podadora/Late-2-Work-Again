using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPj : MonoBehaviour {

	public float VelMov = 1f;
	public float VelMovLat = 0.3f;
	public float JumpVel = 2f;
	public float JumpLong = 3f;
	public float JumpHeigth = 2f;
	private Rigidbody Player;
	private bool Jumping = false;
	// Use this for initialization
	void Start () {
		Player = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		//
		//Movimiento  y Salto
		//
		if (Input.GetKey(KeyCode.W))
		{
			gameObject.transform.Translate (0, 0, VelMov * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S))
		{
			gameObject.transform.Translate (0, 0, -VelMov * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			if (Jumping)
			{
				gameObject.transform.Translate ((-VelMov* JumpVel )* Time.deltaTime, 0,0 );
			}
			else
			{
				gameObject.transform.Translate (-VelMov * Time.deltaTime, 0,0);
			}
		}
		if (Input.GetKey(KeyCode.D))
		{
			if (Jumping)
			{
				gameObject.transform.Translate ((VelMov* JumpVel )* Time.deltaTime, 0,0);
			}
			else
			{
				gameObject.transform.Translate (VelMov * Time.deltaTime, 0,0);
			}
		}

		if (Input.GetKey(KeyCode.Space) && !Jumping)
		{
			Player.velocity = new Vector3 (0, JumpHeigth,JumpLong);
			Jumping = true;
		}
	}
	void OnTriggerEnter(Collider Otro)
	{
		Jumping = false;
	}
}
