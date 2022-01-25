using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TabPanel : EditorWindow
{
    private string[] toolbarStrings = {"New Scenario", "Load Scenario", "Create Quest"};
    private int _toolbar_sel = 0;
    
    private Vector2 offset;
    private Vector2 drag;

    
    [MenuItem("Window/TabPanel")]
    public static void ShowWindow()
    {
        TabPanel window = (TabPanel) GetWindow(typeof(TabPanel));
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        _toolbar_sel = GUILayout.Toolbar(_toolbar_sel, toolbarStrings);
        GUILayout.EndHorizontal();

        switch (_toolbar_sel)
        {
            case 0 :
                //Get the info from the script
                GUILayout.Label("New Scenario");
                if (GUILayout.Button("DrawGrid"))
                {
                    DrawGrid(20f,0.2f,Color.gray);
                }
                break;
            case 1 :
                //Get the info from the script
                GUILayout.Label("Load Scenario");
                if (GUILayout.Button("DrawGrid"))
                {
                    DrawGrid(20f,0.2f,Color.blue);
                }
                break;
            case 2 : 
                //Get the info from the script
                GUILayout.Label("Create Quest");
                if (GUILayout.Button("DrawGrid"))
                {
                    DrawGrid(20f,0.2f,Color.yellow);
                }
                break;
        }
        if (GUI.changed) Repaint();
    }
    
    private void DrawGrid(float gridSpacing, float gridOpacity, Color gridColor)
    {
        Debug.Log("DrawGrid");
        int widthDivs = Mathf.CeilToInt(position.width / gridSpacing);
        int heightDivs = Mathf.CeilToInt(position.height / gridSpacing);

        Handles.BeginGUI();
        Handles.color = new Color(gridColor.r, gridColor.g, gridColor.b, gridOpacity);

        
        offset += drag * 0.5f;
        Vector3 newOffset = new Vector3(offset.x % gridSpacing, offset.y % gridSpacing, 0);

        for (int i = 0; i < widthDivs; i++)
        {
            Handles.DrawLine(new Vector3(gridSpacing * i, -gridSpacing, 0) + newOffset, new Vector3(gridSpacing * i, position.height, 0f) + newOffset);
        }

        for (int j = 0; j < heightDivs; j++)
        {
            Handles.DrawLine(new Vector3(-gridSpacing, gridSpacing * j, 0) + newOffset, new Vector3(position.width, gridSpacing * j, 0f) + newOffset);
        }

        Handles.color = Color.white;
        Handles.EndGUI();
    }
    
    private void OnEnable()
    {


    }



}