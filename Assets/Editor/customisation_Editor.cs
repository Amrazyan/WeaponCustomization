using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(CustomizationSystem))]
public class customisation_Editor : Editor {

	public bool setup_Button;

	//public override void OnInspectorGUI()
	//{
	//	serializedObject.Update();

	//	EditorGUIUtility.LookLikeInspector();

	//	CustomizationSystem cus_System = (CustomizationSystem)target;

	//	cus_System.gameObject.name = cus_System.attachment_Type;

	//	if(!setup_Button)
	//	{
	//		if(GUILayout.Button("Edit " + "[" + cus_System.attachment_Type + "]"))
	//		{
	//			setup_Button = true;
	//		}
	//	}
	//	else
	//	{
	//		EditorGUILayout.LabelField("Attachment Type", EditorStyles.boldLabel);
	//		cus_System.attachment_Type = EditorGUILayout.TextField(cus_System.attachment_Type);

	//		GUILayout.Space(20);

	//		EditorGUILayout.LabelField("Attachment Settings", EditorStyles.boldLabel);

	//		EditorGUILayout.PropertyField(serializedObject.FindProperty("Attachment.all_Attachments"), true);

	//		serializedObject.ApplyModifiedProperties();

	//		GUILayout.Space(10);

	//		if(GUILayout.Button("Hide"))
	//		{
	//			setup_Button = false;
	//		}
	//	}
	//}
}
