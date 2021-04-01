using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlovoMini : MonoBehaviour
{

    [SerializeField] Vector3 force;

    GameObject[] gameObjects;

    [SerializeField] Sprite[] glovoSprites;

    [SerializeField] UIManager UIMgr;

    private Rigidbody2D rb;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = glovoSprites[Random.Range(0,4)];

        transform.position = new Vector3(Random.Range(-7.25f,0.25f),transform.position.y,transform.position.z);

        force = new Vector3(Random.Range(-100,100),Random.Range(150,250),0);

        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if ((collision.gameObject.tag == "topWallGlovo") || (collision.gameObject.tag == "bulletGlovo"))
        {
            
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            UIMgr.AddScore(10);


        }
    }

}
