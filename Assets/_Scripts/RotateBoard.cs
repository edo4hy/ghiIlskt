using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour {

    public GameObject board;
    public float rotationFactor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            board.transform.Rotate(Vector3.right * Time.deltaTime * rotationFactor);
        }
        else if (Input.GetKey(KeyCode.DownArrow))

        {
            board.transform.Rotate(-Vector3.right * Time.deltaTime * rotationFactor);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            board.transform.Rotate(-Vector3.forward * Time.deltaTime * rotationFactor);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            board.transform.Rotate(Vector3.forward * Time.deltaTime * rotationFactor);
        }
		
	}
}
