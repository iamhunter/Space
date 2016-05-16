using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public static int money = 0;
	public Text moneyDisplay;
	public int moneyToBeAdded = 1;

	// Use this for initialization
	void Start () {
		money = 0;
		InvokeRepeating ("addMoney", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		moneyDisplay.text = PlayerPrefs.GetInt ("Money").ToString();
		
	}

	void addMoney()
	{
		money += moneyToBeAdded;
		PlayerPrefs.SetInt ("Money", money);
	}
}
