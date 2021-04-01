using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGo: MonoBehaviour
{
    

    public GameObject PlayerBulletGo;
    public GameObject bulletPosition01;
   
    private Rigidbody2D rb;
    Vector2 input;

    //[serializeField] float speedB;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGo);
            bullet01.transform.position = bulletPosition01.transform.position;

          
        }

        input.y = Input.GetAxis("Vertical");
    }
     private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;  
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "topWallNave")
        {
            Destroy(this.gameObject);
        }

    }


}