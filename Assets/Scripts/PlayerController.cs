using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
	
	Rigidbody2D myBody;
	public float moveForce= 50, turnSpeed = 180;
	public Canvas canvas;

	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate ()
	{
		/*Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
		bool isAction = CrossPlatformInputManager.GetButton ("Action");


		myBody.AddForce (moveVec * (isAction ? boostMultiplier : 1));
		float translation = CrossPlatformInputManager.GetAxis ("Vertical");
		float rotation = CrossPlatformInputManager.GetAxis("Horizontal");*/

		Vector2 moveVec = new Vector2 (0, CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;


		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;




		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * moveForce * Time.deltaTime, 0);

		pos += rot * velocity;
		transform.position = pos;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Planet")) 
		{
			canvas.gameObject.SetActive (true);
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Planet")) 
		{
			canvas.gameObject.SetActive (false);
		}

	}
}
