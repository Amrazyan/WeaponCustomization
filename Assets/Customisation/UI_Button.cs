//Pixel Studios 2016
//Weapon Customisation v1.2

using UnityEngine;
using System.Collections;

public class UI_Button : MonoBehaviour {

	[Header("What attachment holder is this linked to?")]
	//What customisation menu it should activate
	public string attachment_Menu;

	[Header("UI helper")]
	//UI helper which helps changing the attachment customisation menus
	public UI_Menus cs;

	//Checks if you can select this button
	private bool canSelect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Checks if you can click the button
		if(canSelect)
		{
			if(Input.GetMouseButtonDown(0))
			{
				//Change the menu to this attachment type menu
				cs.changeMenu(attachment_Menu);
			}
		}
	
	}

	//Checks if the cursor is on this button
	void OnMouseEnter()
	{
		canSelect = true;
	}

	//Checks if the cursor is off this button
	void OnMouseExit()
	{
		canSelect = false;
	}
}
