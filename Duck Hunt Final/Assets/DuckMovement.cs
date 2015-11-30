﻿using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {

	public float speed;
	public Vector3 Direction;

	void Start()
	{
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
		}
}