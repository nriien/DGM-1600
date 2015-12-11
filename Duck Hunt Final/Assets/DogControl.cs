using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour 
{
	Animator anim;
	
	void Start()
	{
		anim = GetComponent<Animator>();
		GameManager2.OnDuckDeath += PlayDuck;
		GameManager2.OnDuckFlyAway += PlayLaugh;
	}
	

	public void DuckSpawner()
	{
	GameManager2.OnDuckSpawner();
	}
		
	public void PlayLaugh()
	{
	anim.Play("DogLaugh");
	}
		
	public void PlayDuck()
	{
	anim.Play("DogDuck");
	}

}
