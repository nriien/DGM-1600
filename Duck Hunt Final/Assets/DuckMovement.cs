﻿using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {

	public float speed;
	public Vector3 Direction;
	
	private int bounce;
	public int bounceMax;

	void Start()
	{
		GameManager2.OnDuckShot += StopMovement;
		GameManager2.OnDuckMiss += FlyAway;
		RandomDirection();
	}
	
	void Update()
	{
		transform.position = transform.position + (Direction * speed);
		}
		
		public void RandomDirection()
		{
		Direction = new Vector3(Random.Range (-1f, 1f), Random.Range (.2f, 1f), 0);
		}
		
		public void DirectionChanger(Vector3 _dir)
		{
		Direction = new Vector3(Direction.x * _dir.x, Direction.y * _dir.y, 0);
		
		bounce++;
		
		if(bounce >= bounceMax)
			{
			Direction = new Vector3(0, 1, 0);
			GameManager2.OnDuckMiss();
			}
		}
	
	public void StopMovement()
	{
	Direction = new Vector3(0, 0, 0);
	}
	
	public void StartFall()
	{
	Direction = new Vector3(0, -1, 0);
	}
	
	public void FlyAway()
	{
	Direction = new Vector3(0, 1, 0);
	}
}