using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int CantxLin = 8;
	public int Lineas = 5;
	public GameObject[] Car;
	private Vector3 Posinicial =new Vector3(-9,1,-8);
	public Vector3[] Cont;
	private Transform Playertr;
	private GameObject Player;
	public float RangoSpawn = 8;
	private float Posa = -9;
	private float Posb = -8;
	private int Carr = 0;

	void Start () {
		//Lineas
		Player = GameObject.FindGameObjectWithTag("Player");
		Playertr = Player.GetComponent<Transform> ();
		SpawnInicial ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Playertr.transform.position.z>= RangoSpawn) 
		{
			SpawnProg ();
			RangoSpawn += RangoSpawn;
		} 		
	}
	void SpawnInicial ()
	{
		for (int x = 0; x <= Lineas; x++) 
		{
			Instantiate(Car[Carr],transform.position, transform.rotation);
			for (int y = 0; y <= CantxLin; y++) 
			{
				transform.Translate(0,0,Random.Range(1.3f,2f));
				Carr = Random.Range (0, 3);
				Instantiate (Car [Carr], transform.position, transform.rotation);
				if (CantxLin == y) 
				{
					Cont [x] = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
					Posinicial = new Vector3 (Posinicial.x + 1, 1, Posb);
					transform.position = Posinicial;	

				}
			}
		}
	}
	void SpawnProg ()
	{
	for (int x = 0; x<= Lineas;x++)
		{
			transform.position = Cont[x];
		for (int y = 0; y <= CantxLin; y++) 
			{		
				transform.Translate(0,0,Random.Range(1.3f,2f));
				Carr = Random.Range (0, 3);
				Instantiate (Car [Carr], transform.position, transform.rotation);
				if (CantxLin == y) 
				{
					Cont [x] = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				}
			}
		}
	}
}