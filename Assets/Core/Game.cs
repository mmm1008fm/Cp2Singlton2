using ResourseSystemView;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Game
    
    {
        public void StartGame()
        {
            ResourceButton.OnClick += FinishGame;
        }
        public void FinishGame()
        {
            ResourceButton.OnClick -= FinishGame;
            Debug.Log("You lost");
            Time.timeScale = 0;
        }
}
}

