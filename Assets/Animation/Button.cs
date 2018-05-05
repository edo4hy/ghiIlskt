using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	 Animator animator;

	// Use this for initialization
	void Start () {
		 animator = this.gameObject.GetComponentInParent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Alpha1)){
		
			animator.SetTrigger("hitButton");
		}else if(Input.GetKey(KeyCode.Alpha2)){
		
		animator.SetTrigger("offButton");
		}
		
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Player")){

			animator.SetTrigger("hitButton");

		}

	}

		void OnTriggerExit(Collider col){
		if(col.gameObject.CompareTag("Player")){

			animator.SetTrigger("offButton");

		}

	}
}
