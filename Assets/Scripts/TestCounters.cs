using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestCounters : MonoBehaviour {

	public static int money, oxygen, power, resources;
	public Text moneyDisplay, oxygenDisplay, powerDisplay, resourcesDisplay;
	public int moneyToBeAdded, oxygenToBeAdded, powerToBeAdded, resourcesToBeAdded;

	// Use this for initialization
	void Start () {
		money = 0;
		PlayerPrefs.SetInt ("Money", 0);
		InvokeRepeating ("addMoney", 1f, 1f);

		oxygen = 0;
		PlayerPrefs.SetInt ("Oxygen", 0);
		InvokeRepeating ("addOxygen", 1f, 1f);

		power = 0;
		PlayerPrefs.SetInt ("Power", 0);
		InvokeRepeating ("addPower", 1f, 1f);

		resources = 0;
		PlayerPrefs.SetInt ("Resources", 0);
		InvokeRepeating ("addResources", 1f, 1f);

	}

	// Update is called once per frame
	void Update () {
		moneyDisplay.text = PlayerPrefs.GetInt ("Money").ToString();
		oxygenDisplay.text = PlayerPrefs.GetInt ("Oxygen").ToString ();
		powerDisplay.text = PlayerPrefs.GetInt ("Power").ToString();
		resourcesDisplay.text = PlayerPrefs.GetInt ("Resources").ToString ();

	}

	void addMoney()
	{
		PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt("Money")+moneyToBeAdded);
	}

	void addOxygen()
	{
		PlayerPrefs.SetInt ("Oxygen", PlayerPrefs.GetInt("Oxygen")+oxygenToBeAdded);
	}

	void addPower()
	{
		PlayerPrefs.SetInt ("Power", PlayerPrefs.GetInt("Power")+powerToBeAdded);
	}

	void addResources()
	{
		PlayerPrefs.SetInt ("Resources", PlayerPrefs.GetInt("Resources")+resourcesToBeAdded);
	}

	public void DeleteSave()
	{
		PlayerPrefs.DeleteAll();

	}
}
