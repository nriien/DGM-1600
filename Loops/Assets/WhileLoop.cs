using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{

	int cupsinthesink = 4;

	void Start()
	{
		while(cupsinthesink > 0)
		{
			Debug.Log("I washed a cup!");
			cupsinthesink--;
		}
	}
}