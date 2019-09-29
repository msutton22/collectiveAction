using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int currentScore;

    public int scoreAddition = 100;

    public int scoreSubtraction = 10;
    
    public GameObject x;

    public static gameManager instance;

    public GameObject score1;
    
    public bool noteMiss = false;

    public float time = 1f;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score1.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (noteMiss == true)
        {
            Debug.Log(time);
            time -= Time.deltaTime;
            x.SetActive(true);
            if (time <= 0)
            {
                x.SetActive(false);
                time = 1f;
                noteMiss = false;
            }
        }
        else
        {
            x.SetActive(false);
        }
    }

    public void NoteHit()
    {
        currentScore += scoreAddition;
        score1.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
    }
    public void NoteMiss()
    {
        currentScore -= scoreSubtraction;
        score1.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
        noteMiss = true;
    }
}
