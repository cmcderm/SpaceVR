using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {
	public static ShipController instance;
	// Use this for initialization
	Vector3 AngVel;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Roll(float r){ //Around Forward Axis
		AngVel.z = r;
	}

	public void Pitch(float p){ //Around Right Axis
		AngVel.x = p;
	}

	public void Yaw(float y){ //Around Up axis
		AngVel.y = y;
	}
}
