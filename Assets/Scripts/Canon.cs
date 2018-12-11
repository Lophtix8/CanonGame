using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

    public float speed;
    public GameObject canonBall;
    private GameObject temporaryCanonBall;
    private int jumpValue;
    private int lastJumpValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        jumpValue = (int) Input.GetAxisRaw("Jump");
        if (jumpValue == 1 && lastJumpValue == 0){
            temporaryCanonBall = Instantiate(canonBall, transform);
            temporaryCanonBall.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed/4);
        }
        lastJumpValue = jumpValue;
	}
}
