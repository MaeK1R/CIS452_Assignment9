/*
 * Matt Kirchoff
 * MoveFast.cs
 * CIS 452 Assignment9
 * State class for move fast for player, if player goes to edge of screen, reset its postion
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment9
{
    public class MoveFast : Player
    {
        Rigidbody2D rb;
        public Transform Itransform;
        public float speed = .15f;
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
            if (manager.currentState != manager.moveSlow)
            {
                transform.Translate(speed, 0, 0);
            }
        }
        public override void Slow()
        {

           

        }

        public override void Fast()
        {
            //manager.currentState.Fast();
            Debug.Log("Moving fast.");

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
