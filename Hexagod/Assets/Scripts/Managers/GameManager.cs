using UnityEngine;
using HexGrids;

namespace Managers
{
    /// <summary>
    /// This component is responsible for managing the game state. This includes keeping track of what scene the player is in.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        
        /// <summary>
        /// The static reference to the Game Manager. 
        /// </summary>
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject newManager = new GameObject();
                    newManager.AddComponent<GameManager>();

                    _instance = newManager.GetComponent<GameManager>();
                }

                DontDestroyOnLoad(_instance);

                return _instance;
            }
        }
    }
}