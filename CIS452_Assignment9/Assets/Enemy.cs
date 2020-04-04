/*
 * Matt Kirchoff
 * Enemy.cs
 * CIS 452 Assignment9
 * Controls enemy in scene, increases speed over time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform Itransform;
    public float speed;
    public float acceleration;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime * acceleration;
        transform.Translate(speed, 0, 0);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("tele"))
    //    {
    //        transform.position = Itransform.position;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tele"))
        {
            transform.position = Itransform.position;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
            Debug.Log("hit player");
        }
    }
}
