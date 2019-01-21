using UnityEngine;
using System.Collections;
using UnityEditor;

public class customisation_Tools : EditorWindow {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	[MenuItem("Pixel Studios/Version")]
	private static void currentVersion()
	{
		customisation_Tools window = ScriptableObject.CreateInstance<customisation_Tools>();

		window.position = new Rect(Screen.width / 2, Screen.height / 2, 340, 150);
		window.ShowPopup();
	}


	void OnGUI()
	{
		EditorGUILayout.LabelField("Using Pixel Studios Weapon Customisation System V1.1", EditorStyles.wordWrappedLabel);
		GUILayout.Space(90);

		if(GUILayout.Button("Close"))
		{
			this.Close();
		}
	}
}
