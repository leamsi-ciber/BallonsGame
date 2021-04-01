using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject GlovoMiniPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, .6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(GlovoMiniPrefab, transform.position, transform.rotation);
    }
}
