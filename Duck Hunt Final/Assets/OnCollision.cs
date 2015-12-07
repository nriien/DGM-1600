using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour 
{

	public void Start()
	{
		GameManager2.OnDuckShot += turnOff;
		GameManager2.OnDuckMiss += turnOff;
		GameManager2.OnDuckSpawner += turnOn;
	}
 
 public enum Changer {Horizontal, Vertical};
 public Changer direction;

	 public void OnCollisionEnter(Collision hit)
	 {
		
		if(hit.transform.tag == "Duck")
		{
 
	 DuckMovement movement = hit.transform.GetComponent<DuckMovement>();

 	 if(direction == Changer.Horizontal)
 		{
 			movement.DirectionChanger(new Vector3(-1f, 1, 0));
 		}
	 else if(direction == Changer.Vertical)
		 {
 			movement.DirectionChanger(new Vector3(1f, -1f, 0));
		 }
		}
	}
	
	public void turnOff()
	{
		gameObject.SetActive(false);
	}
	
	public void turnOn()
	{
		gameObject.SetActive(true);
	}
}
		
		 
		 