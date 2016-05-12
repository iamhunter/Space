using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public static int money = 0;
	public Text moneyDisplay;

	// Use this for initialization
	void Start () {
		money = 100;
		InvokeRepeating ("addMoney", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		moneyDisplay.text = money.ToString();
		
	}

	void addMoney()
	{
		int moneyToBeAdded = 10;
		money += moneyToBeAdded;
	}
}
