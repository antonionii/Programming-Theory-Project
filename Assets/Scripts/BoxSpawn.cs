using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class BoxSpawn : MonoBehaviour
{
    private float m_spawnXMin = -5.0f;
    public float spawnXMin
    {
        get { return m_spawnXMin; }
        set
        {
            if (value < -5.0f)
            {
                Debug.Log("Needs to be greater than -5");
            }
            else { m_spawnXMin = value; }
        }
    }
    private float m_spawnXMax = 13.0f;
    public float spawnXMax
    {
        get { return m_spawnXMax; }
        set
        {
            if (value > 13.0f)
            {
                Debug.Log("Needs to be less than 13");
            }
            else { m_spawnXMax = value; }
        }
    }


    private float m_spawnZMin = -12.0f; // set min spawn Z
    public float spawnZMin
    {
        get { return m_spawnZMin; }
        set
        {
            if (value < -12.0f)
            {
                Debug.Log("Needs to be greater than 12");
            }
            else { m_spawnZMin = value; }
        }
    }

    private float m_spawnZMax = 5;
    public float spawnZMax
    {
        get { return m_spawnZMax; }
        set
        {
            if (value > 5.0f)
            {
                Debug.Log("Needs to be less than 5");
            }
            else { m_spawnZMax = value; }
        }
    }
    // Start is called before the first frame update

    // Update is called once per fr
    private void OnMouseDown()
    {
        SpawnCharacter();
    }


    public virtual void SpawnCharacter()
    {
        ObjectPooler.Instance.SpawnFromPool("hero", GenerateSpawnPosition(), Quaternion.Euler(0, 90, 0));
        GetComponent<AudioSource>().Play();
    }
    public virtual Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(m_spawnXMin, m_spawnXMax);
        float zPos = Random.Range(m_spawnZMin, m_spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }
}