using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float timeLeft = 45;
	public Text timer;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
		{
			SceneManager.LoadScene("WinMenu");
		}
		timer.text = "Time Left: " + timeLeft.ToString("f0");
	}
}
