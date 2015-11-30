using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour {

public GameObject Duck;

	public void SpawnDuck()
		{
			Instantiate(Duck, transform.position, Quaternion.identity);
		}
}