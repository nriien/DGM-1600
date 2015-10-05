using UnityEngine;
using System.Collections;

public class Part2 : MonoBehaviour

{
	public int apples;
	public int bananas;
	
	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit total: " + answer);
	}
	
	
	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies total: " + answer);
	}
}