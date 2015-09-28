using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{
	void Start()
	{
		bool ShouldContinue = false;

		do
		{
		print("Hello World!");
		}while(ShouldContinue == true);
	}
}