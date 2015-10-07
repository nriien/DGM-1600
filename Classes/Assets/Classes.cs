using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;
		public float fuel;
		
		public Stuff()
		{
			bullets = 1;
			grenades = 1;
			rockets = 1;
		}
		
		public Stuff(int bul, int gre, int roc)
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
		
		public Stuff(int bul, float fu)
		{
			bullets = bul;
			fuel = fu;
		}
	}
		
		
		
	
	
	public Stuff myStuff = new Stuff(50, 5, 5);
	
	public Stuff myOtherStuff = new Stuff(50, 1.5f);
	
	void Start()
	{
		myOtherStuff = myStuff;
		myOtherStuff.bullets = 100;
		
		int int1 = 5;
		int int2 = int1;
		int2 = 100;
		
		Debug.Log(myStuff.bullets); 
		Debug.Log(int1); 
	}
}