using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGo : MonoBehaviour
{
    float speed;
    public AudioClip Sound;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        position = new Vector2(position.x- + speed * Time.deltaTime, position.y);

        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint( new Vector2 (1, 1) );

        if (transform.position.x > max.y)
        {
            Destroy(gameObject);
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletGlovo")
        {
           // ScriptScore.scoreValue += 1;
            Destroy(this.gameObject);
        }
    }
}
