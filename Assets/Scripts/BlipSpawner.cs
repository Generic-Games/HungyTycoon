using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlipSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] blips = null;

    [SerializeField] private float spawnDelay = 1f;

    private void Start()
    {
        StartCoroutine("SpawnBlips");
    }

    private IEnumerator SpawnBlips()
    {
        Vector3 RandomPos = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), -Camera.main.transform.position.z);

        Instantiate(blips[Random.Range(0, blips.Length)], Camera.main.ScreenToWorldPoint(RandomPos), Quaternion.identity, transform);

        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine("SpawnBlips");
    }
}
