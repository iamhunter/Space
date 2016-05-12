using UnityEngine;
using System.Collections;

public class PlayerPlanetInteraction : MonoBehaviour {
	
	public Canvas canvas;



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
