using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Blip", menuName = "SO/Blip")]
public class SO_Blips : ScriptableObject
{
    public GameObject prefab = null;

    public int pointValue = 1;
    public int spawnLevel = 0;
    public float spawnTime = 1f;
    public float maxSize = 0.8f;
    public float minSize = 1.2f;
}
