using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainBehavior : MonoBehaviour
{
    public float speed;
    public bool started;

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
