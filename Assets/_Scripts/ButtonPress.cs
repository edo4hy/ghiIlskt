using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

	bool ballCollided = false;

	public float buttonMove = 0.025f;

	public GameObject buttonParent;
	public float speed;

	private Transform target;
	
	
	// Use this for initialization
	void Start () {
		target = this.transform;

		this.transform.parent = buttonParent.transform;
	}
	
	// Update is called once per frame
	void Update () {


		if(ballCollided){
			Debug.Log("Button Pressed");
			if(transform.position.y > 0.025f){
				Vector3 offset = new Vector3(0f, -0.025f, 0f );
				transform.localPosition = target.TransformPoint(offset);
			}
			

		}else{
			if(transform.position.y < 0f){
				Vector3 offset = new Vector3(0f, 0f, 0f );
				transform.localPosition = target.TransformPoint(offset);
			}
		}	

			
			
	
		
	}

    private void OnTriggerEnter(Collider other)
    {

		if(other.gameObject.CompareTag("Player")){
		
			ballCollided = true;

		}
        
    }

    private void OnTriggerExit(Collider other)
    {
		if(other.gameObject.CompareTag("Player")){
		
			ballCollided = false;

		}
		
    }

}
