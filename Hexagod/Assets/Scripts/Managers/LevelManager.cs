using HexGrids;
using UnityEngine;

namespace Managers
{
    /// <summary>
    /// Responsible for manage the state of the level. Contains the map and other level related information. 
    /// </summary>
    public class LevelManager : MonoBehaviour
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

                return _instance;
            }
        }

        private HexMap _levelMap;

        public HexMap LevelMap
        {
            get => _levelMap;
        }
    }
}
