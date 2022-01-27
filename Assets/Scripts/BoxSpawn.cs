using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class BoxSpawn : MonoBehaviour
{
    [SerializeField] GameObject hero;


    private float spawnXMin = -5;
    private float spawnXMax = 13;

    private float spawnZMin = -12; // set min spawn Z
    private float spawnZMax = 5; // set ma
    // Start is called before the first frame update

    // Update is called once per fr
    private void OnMouseDown()
    {
        ObjectPooler.Instance.SpawnFromPool("hero", GenerateSpawnPosition(), Quaternion.Euler(0, 90, 0));
        GetComponent<AudioSource>().Play();
    }


    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(spawnXMin, spawnXMax);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }
}