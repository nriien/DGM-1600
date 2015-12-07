using UnityEngine;
using System.Collections;

public class GameManager2 : MonoBehaviour 
{
	public delegate void DuckDel();
	public static DuckDel OnDuckSpawner;
	public static DuckDel OnDuckShot;
	public static DuckDel OnDuckDeath;
	public static DuckDel OnDuckFlyAway;
	public static DuckDel OnDuckMiss;
}
