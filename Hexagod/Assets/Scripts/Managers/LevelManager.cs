using HexGrids;
using UnityEngine;

namespace Managers
{
    /// <inheritdoc />
    /// <summary>
    /// Responsible for manage the state of the level. Contains the map and other level related information. 
    /// </summary>
    public class LevelManager : MonoBehaviour
    {
        
        private static LevelManager _instance;
        /// <summary>
        /// The static reference to the Game Manager. 
        /// </summary>
        public static LevelManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject newManager = new GameObject();
                    newManager.AddComponent<LevelManager>();

                    _instance = newManager.GetComponent<LevelManager>();
                }

                return _instance;
            }
        }

        private HexMap _levelMap;

        public HexMap LevelMap => _levelMap;

        /// <summary>
        /// Adds the tile to the map.
        /// </summary>
        /// <param name="tileToAdd">The tile that will be added to the map.</param>
        public void AddTileToMap(Hex tileToAdd)
        {
            //TODO: Implement functionality for this.
        }
    }
}
