using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour {

	Animator anim;
	
	bool isInvincible;
	
	void Start()
	{
	GameManager2.OnDuckMiss += MakeInvincible;
	GameManager2.OnDuckShot += MakeInvincible;
	}

	void OnTriggerEnter (Collider hit)
	{
			if (hit.tag == "Killzone")
			{
				Destroy(gameObject);
			}
			
			if (hit.tag == "FlyZone")
			{
				GameManager2.OnDuckFlyAway();
				Destroy(gameObject);
			}
	}
	
	public void KillDuck()
	{
		if(isInvincible == false)
		{
		anim.Play("DuckDeath");
		GameManager2.OnDuckShot();
		}
	}
	
	public void MakeInvincible()
	{
		isInvincible = true;
	}
	
}