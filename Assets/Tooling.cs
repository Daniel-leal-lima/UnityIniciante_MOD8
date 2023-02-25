using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tooling : MonoBehaviour
{
    [MenuItem("GameObject/Empilhar",priority = 0)]
    public static void Empilhar(MenuCommand menuCommand)
    {
        float z_transform = 0;
        float acres = 1;
        if (Selection.objects.Length > 0)
        {
            foreach(GameObject obj in Selection.objects)
            {
                float z_value = z_transform + acres;
                obj.transform.position = new Vector3(0,0,z_value);
                z_transform += acres;
            }
        }

    }
    [MenuItem("GameObject/Send to last Position %l", priority = 1)]
    public static void SendToLastPosInHierarchy(MenuCommand menuCommand)
    {
        if(Selection.objects.Length > 0)
        {
            foreach (GameObject obj in Selection.objects)
            {
                obj.transform.parent = null;
            }
        }
    }
}
