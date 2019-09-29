using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (-speed, 0));
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, speed));
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, -speed));
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, -speed));
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            this.GetComponent<Transform> ().Translate (new Vector3 (0, speed));
        }
    }
}