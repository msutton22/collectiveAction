﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainBehavior : MonoBehaviour
{
    public float speed;
    public bool started;
    public string text;

    public GameObject startText;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 60f;
        startText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager2.instance2.counter == 67)
        {
            if (gameManager2.instance2.currentScore > gameManager.instance.currentScore)
            {
                text = "Player 1 wins! Press Space to start over!";
            }
            else if (gameManager2.instance2.currentScore < gameManager.instance.currentScore)
            {
                text = "Player 2 wins! Press Space to start over!";
            }
            else
            {
                text = "It's a tie! Press Space to start over!";
            }
            startText.gameObject.GetComponent<Text>().text = text;
            startText.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("MainScene");
            }
        }
        if (!started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                started = true;
                startText.SetActive(false);
            }
        }
        else
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }
}
