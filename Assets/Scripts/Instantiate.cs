using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        string[] placementFile = File.ReadAllLines("Assets/Resources/placementOrigin.txt");
        for (int i = 0; i < placementFile.Length; i++)
        {
            string holder = placementFile[i];
            string[] placement = holder.Split(',');

            // name, path, locationX, locationY, locationZ, scale, rotationX, rotationY, rotationZ, rotationW
            string pat = "\"?([^\"]+)\"?, ?\"?([^\"]+)\"?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?, ?([0-9.-]+)f?";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Match m = r.Match(holder);
            if (!m.Success)
            {
				Debug.Log("Did not match regex: " + holder);
                continue;
            }

            GroupCollection g = m.Groups;
            string name = g[1].Value;
            string path = g[2].Value;

            GameObject prefab = Resources.Load(path) as GameObject;
            if (prefab == null)
            {
				Debug.Log("Couldn't find prefab: " + path);
                continue;
            }
            GameObject placedThing = Instantiate(prefab);

            placedThing.name = name;

            float x = float.Parse(g[3].Value) ;//* -2.0f;
            float y = float.Parse(g[4].Value);
            float z = float.Parse(g[5].Value);// * 2.0f;
            Vector3 location = new Vector3(x, y, z);

            float s = float.Parse(g[6].Value);// * 1.75f;
            Vector3 scale = new Vector3(s, s, s);

            float qx = float.Parse(g[7].Value);
            float qy = float.Parse(g[8].Value);
            float qz = float.Parse(g[9].Value);
            float qw = float.Parse(g[10].Value);
            Quaternion rotation = new Quaternion(qx, qy, qz, qw);

            placedThing.transform.position = location;
            placedThing.transform.localScale = scale;
            placedThing.transform.rotation = rotation;
        }
    }
}