using UnityEngine;
using System.Collections;

public class VandF : MonoBehaviour {
	int Myint = 22;

	void Start()
	{
		Myint = MultiplyByTwo(Myint);
		Debug.Log (Myint);
	}

	int MultiplyByTwo(int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}

}
