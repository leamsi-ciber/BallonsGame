using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBallet : MonoBehaviour
{
    GameObject[] gameObjects;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GlovoXbullet")
        {
            Destroy(this.gameObject);
        }
    }

}
