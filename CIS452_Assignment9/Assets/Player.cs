/*
 * Matt Kirchoff
 * Player.cs
 * CIS 452 Assignment9
 * Holds abstract classes for the states for the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment9
{
    public abstract class Player : MonoBehaviour
    {

        public abstract void Slow();
        public abstract void Fast();

    }
}

