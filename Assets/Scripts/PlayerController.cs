using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
	
	Rigidbody2D myBody;
	public float moveForce= 5, boostMultiplier = 10;

	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
		bool isAction = CrossPlatformInputManager.GetButton ("Action");


		myBody.AddForce (moveVec * (isAction ? boostMultiplier : 1));

	}
}
