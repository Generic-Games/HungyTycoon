using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script handles when the BlipSpawner is allowed to spawn blips
public class BlipSpawnManager : MonoBehaviour
{
    public float currentSpawnLevel = 0;

    public void LevelUp()
    {
        currentSpawnLevel++;
    }
}
