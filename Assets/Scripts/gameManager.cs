using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int currentScore;

    public int scoreAddition = 100;

    public int scoreSubtraction = 10;

    public static gameManager instance;

    public GameObject score1;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score1.gameObject.GetComponent<Text>().text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}
