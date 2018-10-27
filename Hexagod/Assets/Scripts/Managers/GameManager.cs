using UnityEngine;

namespace Managers
{
    /// <summary>
    /// This component is responsible for managing the game state. This includes keeping track of what scene the player is in.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
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
    }
}