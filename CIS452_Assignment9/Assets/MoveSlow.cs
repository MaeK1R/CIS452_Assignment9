/*
 * Matt Kirchoff
 * MoveSlow.cs
 * CIS 452 Assignment9
 * State class for move slow for player, if player goes to edge of screen, reset its postion
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment9
{
    public class MoveSlow : Player
    {
        Rigidbody2D rb;
        public Transform Itransform;
        public float speed = .05f;
        public PlayerManager manager;
        
        // Start is called before the first frame update
        void Start()
        {
            Itransform = GameObject.FindGameObjectWithTag("starting").transform;
            rb = GetComponent<Rigidbody2D>();
            manager = GetComponent<PlayerManager>();

        }

        // Update is called once per frame
        void Update()
        {
            if (manager.currentState != manager.moveFast)
            {
                transform.Translate(speed, 0, 0);
            }
        }
        public override void Slow()
        {
            
            Debug.Log("Moving slow.");
            
        }

        public override void Fast()
        {
            

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("tele"))
            {
                
                transform.position = Itransform.position;
            }
        }
    }

}
