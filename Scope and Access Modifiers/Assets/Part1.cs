using UnityEngine;
using System.Collections;

public class Part1 : MonoBehaviour
{
	public int alpha = 5;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private Part2 myOtherClass;
	
	
	void Start ()
	{
		alpha = 29;
		
		myOtherClass = new Part2();
		myOtherClass.FruitMachine (alpha, myOtherClass.apples);
	}
	
	
	void Example (int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * alpha;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		Debug.Log("Alpha is set to: " + alpha);
	}
}