//Pixel Studios 2016
//Weapon Customisation v1.2

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pl_WeaponManager : MonoBehaviour {

	//Your primary weapon
	public GameObject Primary;

	//Your secondary weapon
	public GameObject Secondary;

	// Use this for initialization
	void Start () {

		//Sets the primary weapon as the first weapon on start
		Primary.SetActive(true);
		Secondary.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {

		//Selects the primary weapon
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			Primary.SetActive(true);
			Secondary.SetActive(false);
		}

		//Selects the secondary weapon
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			Primary.SetActive(false);
			Secondary.SetActive(true);
		}

		//Returns to the customisation screen
		if(Input.GetKeyDown(KeyCode.Tab))
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene("Example_Scene");
		}
	
	}
}
