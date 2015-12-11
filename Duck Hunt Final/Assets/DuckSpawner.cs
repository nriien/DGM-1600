using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour {

	public GameObject Duck;
	
	void Start()
	{
	GameManager2.OnDuckSpawner += SpawnDuck;
	}


	public void SpawnDuck()
	{
	Instantiate(Duck, transform.position, Quaternion.identity);
	}
	
}