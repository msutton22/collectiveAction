using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    public AudioSource background;
    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
           if (Input.GetKeyDown(KeyCode.Space))
           {
               background.Play();
           }
        
    }
}
