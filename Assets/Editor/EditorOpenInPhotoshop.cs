using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using UnityEditor;

public class EditorOpenInPhotoshop 
{
    const string ItemName = "Assets/Open in Photoshop";

   [MenuItem(ItemName,false)]
    static void Open()
    {
        foreach (var guid in Selection.assetGUIDs)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var fullPath = Path.GetFullPath(path);
            Process.Start("photoshop", fullPath);
        }
    }
}
