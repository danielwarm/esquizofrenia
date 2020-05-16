using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Database))]
public class DatabaseEditor : Editor {

    private Database database;

    private string searchString;

    private bool shouldSearch;

    private void OnEnable()
    {
        database = (Database)target;
    }

    public override void OnInspectorGUI()
    {
        if (database)
        {
            EditorGUILayout.BeginHorizontal("Box");
            GUILayout.Label("Items in Database: " + database.items.Count);
            EditorGUILayout.EndHorizontal();

            foreach (Item item in database.items)
            {
                //dibujar la representacion del item
                DispalyItem(item);
            }
        }
    }   
    
    private void DispalyItem(Item item)
    {
        GUIStyle labelStyle = new GUIStyle(GUI.skin.label);
        labelStyle.wordWrap = true;

        EditorGUILayout.BeginVertical("Box");
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("ID: ");
        GUILayout.Label(item.id.ToString(), labelStyle);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();

    }
 }
