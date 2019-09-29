using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager2 : MonoBehaviour
{
    public int currentScore;

    public int scoreAddition = 100;
    
    public int scoreSubtraction = 10;

    public int counter;

    public static gameManager2 instance2;

    public GameObject score2;
    // Start is called before the first frame update
    void Start()
    {
        instance2 = this;
        score2.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteHit()
    {
        currentScore += scoreAddition;
        score2.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
        counter += 1;
    }
    public void NoteMiss()
    {
        currentScore -= scoreSubtraction;
        score2.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
        counter += 1;
    }
}
