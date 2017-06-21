using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Controls : MonoBehaviour {
	Hand _hand; //not sure if needed
	ShipController sc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HandAttachedUpdate(Hand hand){
		if (hand.controller.GetTouch(SteamVR_Controller.ButtonMask.Touchpad)) {
			Vector2 touchAxes = hand.controller.GetAxis();
			float x = touchAxes.x;
			float y = touchAxes.y;
			sc.Roll (x);
			sc.Pitch (y);
		}
	}
}
