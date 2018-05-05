using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallThroughHole : MonoBehaviour {

    public Vector3 startPosition;
    public GameObject board;
    public GameObject sphere;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        Object.Destroy(collision.gameObject);

        board.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

        GameObject.Instantiate(sphere);
    }
}
