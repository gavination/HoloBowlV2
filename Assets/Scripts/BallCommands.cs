using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCommands : MonoBehaviour {

    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateBall()
    {
        Vector3 ballPosition = Camera.main.transform.position + Camera.main.transform.forward * 1f;
        //Vector3 BallDirection = Camera.main.transform.forward;

        Instantiate(ball, ballPosition, Quaternion.identity);


    }
}
