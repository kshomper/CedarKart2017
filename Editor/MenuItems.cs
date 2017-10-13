using UnityEngine;
using UnityEditor;

public class MenuItems
{
    [MenuItem("My Project/Create Simple Prefab")]
    static void DoCreateSimplePrefab()
    {
        Transform[] transforms = Selection.transforms;
        foreach (Transform t in transforms)
        {
            Object prefab = PrefabUtility.CreateEmptyPrefab("Assets/Resources/" + t.gameObject.name + ".prefab");
            PrefabUtility.ReplacePrefab(t.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
        }
    }
}