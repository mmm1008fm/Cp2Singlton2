using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{

    public class Bootstrapper : MonoBehaviour
    {
        private Game _game;
        private void Awake()
        {
            _game = new();

            _game.StartGame();
        }
    }
}
