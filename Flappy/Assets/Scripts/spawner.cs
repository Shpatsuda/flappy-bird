using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void Start()
    {

        InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);

    }
    private void Spawn()
    {

        GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);

    }


}
