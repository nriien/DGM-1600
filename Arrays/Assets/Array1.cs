using UnityEngine;
using System.Collections;

public class Array1 : MonoBehaviour{

GameObject[] players;

void Start()
{
players = GameObject.FindGameObjectsWithTag("Player");

for(int i = 0; i < players.Length; i++)
{
Debug.Log("Player number"+i+"is named "+players[i].name);
}
}
}