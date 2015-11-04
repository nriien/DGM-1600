using UnityEngine;
using System.Collections;

public class Enumeration : MonoBehaviour {

enum Direction {North, South, East, West};

void Start()
	{
		Direction MyDirection;
		MyDirection = Direction.North;
	}

	Direction ReverseDirection (Direction dir)
	
	{
		if (dir == Direction.North)
		dir = Direction.South;
		
		return dir;
	}
}