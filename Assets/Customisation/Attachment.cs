//Pixel Studios 2016
//Weapon Customisation v1.2

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attachment : MonoBehaviour {

	//All your attachments on your in-game weapon
	public List<GameObject> all_Attachments = new List<GameObject>();

	//Your attachment holder type. *Note* This have to be namned EXACTLY THE SAME as your "customisation screen weapon attachment holder's" attachment type!
	public string attachment_Type;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Syncs the attachment changing process for this attachment holder type
		for(int i = 0; i < all_Attachments.Count; i++)
		{
			if(all_Attachments[i].name == PlayerPrefs.GetString(attachment_Type))
			{
				all_Attachments[i].SetActive(true);
			}
		}

	}
}
