using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour 
{
 
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
}
		
		 
		 