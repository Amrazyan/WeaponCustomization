using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Seperate))]
public class separate_Editor : Editor {

	public UI_Menus source;

	public bool showResetButton;

	public override void OnInspectorGUI()
	{
		Seperate seperate = (Seperate)target;

		serializedObject.Update();

		EditorGUIUtility.LookLikeInspector();

		EditorGUILayout.LabelField("Customisable Parts", EditorStyles.boldLabel);

		EditorGUILayout.PropertyField(serializedObject.FindProperty("cus_Parts"), true);

		GUILayout.Space(10);

		EditorGUILayout.LabelField("Resets all customisation positions", EditorStyles.boldLabel);

		if(!showResetButton)
		{
			if(GUILayout.Button("Show"))
			{
				showResetButton = true;
			}
		}

		if(showResetButton)
		{
			if(GUILayout.Button("Set all positions"))
			{
				foreach(Seperate.customisable transforms in seperate.cus_Parts)
				{
					transforms.customisable_Position = new Vector3(transforms.customisable_Transform.localPosition.x, transforms.customisable_Transform.localPosition.y, transforms.customisable_Transform.localPosition.z);
				}
			}

			GUILayout.Space(5);

			if(GUILayout.Button("Hide"))
			{
				showResetButton = false;
			}
		}

		GUILayout.Space(10);

		EditorGUILayout.LabelField("UI Attachment Holder Buttons", EditorStyles.boldLabel);

		EditorGUILayout.PropertyField(serializedObject.FindProperty("UI_Buttons"), true);

		serializedObject.ApplyModifiedProperties();

		GUILayout.Space(10);

		EditorGUILayout.LabelField("Separate Sound Effect", EditorStyles.boldLabel);
		seperate.seperate_Sound = (AudioClip) EditorGUILayout.ObjectField(seperate.seperate_Sound, typeof(AudioClip), false);

	}
}
