using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, speed));
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, -speed));
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, -speed));
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, speed));
        }
    }
}
