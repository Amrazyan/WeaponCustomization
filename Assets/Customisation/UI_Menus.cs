//Pixel Studios 2016
//Weapon Customisation v1.2


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class UI_Menus : MonoBehaviour {

	[Header("A list of your attachment holders")]
	//A list of customisation systems, like Sights, Magazines, Barrels, Rails etc.
	public List<GameObject> customisation_Systems = new List<GameObject>();

	//Helps showing a specific attachment customisation menu while hiding everyone else
	public void changeMenu(string Menu)
	{
		foreach(GameObject csSystems in customisation_Systems)
		{
			csSystems.GetComponent<CustomizationSystem>().changeMenu(Menu);
		}
	}


	void OnGUI()
	{
		if(GUI.Button(new Rect(750, 0, 200, 50), "Test Weapon"))
		{
			SceneManager.LoadScene("Test Scene");
		}
	}
}
