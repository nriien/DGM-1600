using UnityEngine;
using System.Collections;

public class CandS : MonoBehaviour{
	private 
{
	float HeightTest = 3f;

	void Start()
		{
		Debug.Log(transform);
		if(transform <= HeightTest);
		Debug.Log("I'm about to hit the ground!");
		}
			
	void FlyAway()
		{
		if(transform >= HeightTest);
		Debug.Log("I'm flying!");
		}
				
	void FlyAway()
		{
		Debug.Log("Fly Away!");
		Vector3 newPosition = new Vector3 (0, 7, 0);
		transform.position = newPosition;
		}
}