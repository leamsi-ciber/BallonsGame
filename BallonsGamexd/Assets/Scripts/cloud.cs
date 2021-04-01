using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    [Range(0.5f, 1.5f)]
    public float velocidad;
    GameObject fondo;
    float limiteJuego, posicionInicialX;
    // Start is called before the first frame update
    void Start()
    {
        fondo = GameObject.Find("Fondo");
        limiteJuego = fondo.GetComponent<SpriteRenderer>().bounds.extents.x;

        //Capturo la posición inicial en x para cuando tenga que recolocar la nube
        posicionInicialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = new Vector2(Time.deltaTime * velocidad, 0);

        //Muevo la nube con ese vector
        transform.Translate(movimiento);

        //Si la nube se sale completamente de la escena por la derecha, la recoloco a la izquierda
        //con otra altura y otra escala (lo multiplico por 1.25 para asegurarme de que la nube ha salido completamente).
        if (transform.position.x > limiteJuego * 1.25f)
        {
            //Escala aleatoria en x e y (z se queda fija)
            transform.localScale = new Vector3(Random.Range(0.2f, 0.4f), Random.Range(0.2f, 0.4f), transform.localScale.z);

            //Posición inicial en x y aleatoria en y
            transform.position = new Vector2(posicionInicialX, Random.Range(0.5f, 1.5f));
        }

    }
}
