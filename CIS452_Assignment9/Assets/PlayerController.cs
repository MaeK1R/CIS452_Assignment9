/*
 * Matt Kirchoff
 * PlayerController.cs
 * CIS 452 Assignment9
 * Controls player using space, toggles between 2 states of moving fast and slow
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment9
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerManager manager;
        private bool slow = true;

        // Start is called before the first frame update
        void Start()
        {
            //manager.currentState.Slow();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(slow)
                {
                    
                    Debug.Log("fast move");
                    manager.currentState.Fast();
                    slow = false;
                }
                else if(!slow)
                {
                    Debug.Log("slow move");
                    manager.currentState.Slow();
                    slow = true;
                }
                    
            }

        }
    }
}

