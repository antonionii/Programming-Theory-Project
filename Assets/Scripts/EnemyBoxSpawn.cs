using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyBoxSpawn : BoxSpawn
{
    // Update is called once per fr
    private void OnMouseDown()
    {
        SpawnCharacter();
    }

    //Inheritance and
    // Polymorphism below. Adjusted SpawnCharacter 
    public override void SpawnCharacter()
    {
        ObjectPooler.Instance.SpawnFromPool("Enemy", GenerateSpawnPosition(), Quaternion.Euler(0, 90, 0));
        GetComponent<AudioSource>().Play();
    }

    public override Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(spawnXMin, spawnXMax);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 5, zPos);
    }

}