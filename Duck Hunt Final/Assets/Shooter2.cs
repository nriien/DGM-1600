using UnityEngine;
using System.Collections;

public class Shooter2 : MonoBehaviour 
{
	RaycastHit hit;
	private int bulletAmt;
	public int maxBullets;
	
	void Start()
	{
	GameManager2.OnDuckSpawner += ResetBullets;
	}
	
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			bulletAmt--;
			
			if(bulletAmt <= 0)
			{
			GameManager2.OnDuckMiss();
			}
			
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;
			
			if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos),Camera.main.transform.forward, out hit,Mathf.Infinity))
			{
				{
				if(hit.transform.tag == "Duck")
				{
					DuckHealth movement = hit.transform.GetComponent<DuckHealth>();
				}
			}
		}
	}
}

	public void ResetBullets()
	{
		bulletAmt = maxBullets;
	}
	
}
