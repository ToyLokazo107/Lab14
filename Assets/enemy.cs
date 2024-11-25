using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocidad;
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Menu");
        }
        if(collision.gameObject.tag == "pared")
        {
            Destroy(this.gameObject);
        }
    }
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _componentRigidbody2D.velocity = new Vector2(0, velocidad);
    }
}