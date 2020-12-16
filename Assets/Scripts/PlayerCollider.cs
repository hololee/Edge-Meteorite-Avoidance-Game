using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D() {
      
        animator.SetTrigger("collided");

    }
}
