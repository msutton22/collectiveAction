﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowBehavior : MonoBehaviour
{
    public bool pressed;

    public KeyCode key;
    private int counter;

    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (pressed == true)
            {
                particles.Play();
                gameObject.SetActive(false);
                gameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
         {
             if (collision.tag == "button")
             {
                 pressed = true;
             }
         }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "button")
        {
            pressed = false;
            gameManager.instance.NoteMiss();
        }
    }
}
