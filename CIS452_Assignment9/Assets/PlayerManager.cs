/*
 * Matt Kirchoff
 * PlayerManager.cs
 * CIS 452 Assignment9
 * Manager class for player states
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CIS452_Assignment9
{
    public class PlayerManager : MonoBehaviour
    {
        public Player moveSlow { get; set; }
        public Player moveFast { get; set; }

        public int score = 0;
        public Text scoreText;

        public Player currentState { get; set; }
        // Start is called before the first frame update
        void Start()
        {
            moveSlow = gameObject.AddComponent<MoveSlow>();
            moveFast = gameObject.AddComponent<MoveFast>();
            currentState = moveSlow;
        }

        public void Slow()
        {
            currentState.Slow();
        }
        public void Fast()
        {
            currentState.Fast();
        }
        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("tele"))
            {

                score = score + 1;
                scoreText.text = ("Score: " + score.ToString());
            }
        }

    }
}

