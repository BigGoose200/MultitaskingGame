﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("RedGoal"))
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag.Equals("GreenGoal"))
        {
            SceneManager.LoadScene("LoseMenu");
        }
    }
}
