using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class GameManager : MonoBehaviour
{

    ObjectPooler objectPooler;

    [SerializeField] float spawnRate;

    void Start()

    {
        objectPooler = ObjectPooler.Instance;
    }
    void Update()
    {

    }
}
