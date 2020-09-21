using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
	public GameObject orbPrefab; // var to hold prefab for instantiating orbs
	public GameObject orbPrefab2; // var to hold prefab for instantiating orbs
	public float secsBetweenLaunch = 4f; // rate that we generate orbs from the ship

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("LaunchOrb", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
		InvokeRepeating("LaunchOrb2", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
	}
	void LaunchOrb()
	{
		GameObject A = Instantiate(orbPrefab);
		A.transform.position = new Vector2(Random.Range(-5, 8), Random.Range(6, 7));
	}

	void LaunchOrb2()
	{
		GameObject B = Instantiate(orbPrefab2);
		B.transform.position = new Vector2(Random.Range(-5, 8), Random.Range(6, 7));
	}

	// Update is called once per frame
	void Update()
	{


	}
}