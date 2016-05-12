using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {
	

	public SpriteRenderer playerSprite;
	public Sprite newSprite;

	public void changeShip()
	{
		playerSprite.sprite = newSprite;
		Money.money -= 200;
	}

}
