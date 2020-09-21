using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CapacityMeter : MonoBehaviour
{

    public int cMeter; // var that tracks the player's health
    public Text cMeterText; // var that displays health

    // Start is called before the first frame update
    void Start()
    {
        cMeterText.text = "Capacity Meter: " + cMeter; // displays health
    }

    // Update is called once per frame
    void Update()
    {
        // checks to see if the meter lost all of their health
        if (cMeter <= 0)
        {
            SceneManager.LoadScene("LoseMenu");
        }
    }

    // this function is used to check for collisions
    void OnCollisionEnter2D(Collision2D other)
    {
        // checks to see if the red square is touching the platform
        if (other.gameObject.tag == "Red")
        {
            cMeter -= 10; // take away one health point
            cMeterText.text = "Capacity Meter: " + cMeter; // displays health
        }

        // checks to see if the green square is touching the platform
        if (other.gameObject.tag == "Green")
        {
            cMeter -= 10; // take away one health point
            cMeterText.text = "Capacity Meter: " + cMeter; // displays health
        }
    }
}
