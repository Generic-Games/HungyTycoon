using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlipSpawner : MonoBehaviour
{
    [SerializeField] private BlipSpawnManager spawnManager = null;
    [SerializeField] private SO_Blips blips = null;

    private void Start()
    {
        StartCoroutine("SpawnBlips");
    }

    private IEnumerator SpawnBlips()
    {
        Vector3 RandomPos = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), -Camera.main.transform.position.z);

        if (blips.spawnLevel <= spawnManager.currentSpawnLevel)
        {
            Instantiate(blips.prefab, Camera.main.ScreenToWorldPoint(RandomPos), Quaternion.identity, transform);
        }

        yield return new WaitForSeconds(blips.spawnTime);
        StartCoroutine("SpawnBlips");
    }
}
