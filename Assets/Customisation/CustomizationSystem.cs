//Pixel Studios 2016
//Weapon Customisation v1.2

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CustomizationSystem : MonoBehaviour {

	//What type of attachment holder this is. For example: Sights, Magazines, Barrels, Rails etc.
	public string attachment_Type;

	//Checks if the GUI menu should be visible
	private bool cs_AttachmentsMenu;

	//Checks if you reached the end of the attachment list
	private int limitCheck;


	[System.Serializable]
	public class Attachments
	{
		//Checks what attachment is showing
		[HideInInspector]
		public int current_Attachment;

		//A list for all your attachments for this attachment holder
		//public List<GameObject> all_Attachments = new List<GameObject>();

		public List<string> all_Attachments = new List<string>();		

		//Checks if the "Next" GUI button should be visible
		[HideInInspector]
		public bool showNext = true;

		//Checks if the "Previous" GUI button should be visible
		[HideInInspector]
		public bool showPrevious = true;
	}
	[System.Serializable]
	public class WeaponsPosition
	{
		public string name;
		public Vector3 position;
		public Vector3 rotation;
		public Vector3 scaleFactor;
	}

	[Space(10)]

	public List<WeaponsPosition> weaponsPositions;

	[Space(10)]

	public Attachments Attachment;

	// Use this for initialization
	void Start () {

		//PlayerPrefs.SetString(attachment_Type, Attachment.all_Attachments[Attachment.current_Attachment].name);
		PlayerPrefs.SetString(attachment_Type, Attachment.all_Attachments[Attachment.current_Attachment]);

	}

	//Shows or hides the GUI customisation menu
	public void changeMenu(string Menu)
	{
		if(Menu == attachment_Type)
		{
			cs_AttachmentsMenu = true;
		}
		else
		{
			cs_AttachmentsMenu = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

		//Checks if you reached the end or the beginning of the attachment list and if so, hides either the "Next" or "Previous" button

		if(cs_AttachmentsMenu)
		{
			limitCheck = Attachment.all_Attachments.Count;
			limitCheck -= 1;

			if(Attachment.current_Attachment <= 0)
			{
				Attachment.current_Attachment = 0;
				Attachment.showPrevious = false;
			}
			else
			{
				Attachment.showPrevious = true;
			}

			if(Attachment.current_Attachment == limitCheck)
			{
				Attachment.showNext = false;
			}
			else
			{
				Attachment.showNext = true;
			}

		}
	}
	string name;
	void OnGUI()
	{
		//Checks if the GUI customisation menu should be visible
		if(cs_AttachmentsMenu)
		{
			//Displays the attachment name, remember to rename the attachment object to a proper name!
			//GUI.Box(new Rect(0, 100, 200, 100), Attachment.all_Attachments[Attachment.current_Attachment].name);
			name = Attachment.all_Attachments[Attachment.current_Attachment];
			GUI.Box(new Rect(0, 100, 200, 100), name);

			PlayerPrefs.SetString(attachment_Type, name);

			//Checks if "Previous" button should be visible
			if(Attachment.showPrevious)
			{
				if(GUI.Button(new Rect(0, 200, 50, 50), "<"))
				{
					Attachment.current_Attachment -= 1;
					changeAttachment();
				}
			}

			//Checks if "Previous" button should be visible
			if(Attachment.showNext)
			{
				if(GUI.Button(new Rect(150, 200, 50, 50), ">"))
				{
					Attachment.current_Attachment += 1;
					changeAttachment();
				}
			}
		}
	}


	void changeAttachment()
	{
		//foreach(GameObject all_attachments in Attachment.all_Attachments)
		//{
		//	all_attachments.SetActive(false);
		//}

		//Attachment.all_Attachments[Attachment.current_Attachment].SetActive(true);
		for (int i = 1; i < this.transform.childCount; i++)
		{
			Destroy(this.transform.GetChild(i).gameObject);
		}
		
		//foreach (var all_attachments in Attachment.all_Attachments)
		{
			WeaponsPosition wp = weaponsPositions.Find(item => item.name == name);
			
			Debug.Log(name);

			GameObject weaponObject = Resources.Load(name) as GameObject;


			//weaponObject.transform.parent = this.transform;			

			GameObject weaponObject1 = Instantiate(weaponObject);
			weaponObject1.transform.parent = this.transform;

			weaponObject1.transform.localPosition = wp.position;
			weaponObject1.transform.localEulerAngles = wp.rotation;
			weaponObject1.transform.localScale = wp.scaleFactor;
		}

		//Attachment.all_Attachments[Attachment.current_Attachment].SetActive(true);
	}
}
