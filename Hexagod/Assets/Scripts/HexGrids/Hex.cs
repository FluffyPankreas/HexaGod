using UnityEngine;

namespace HexGrids
{
    /// <summary>
    /// This is the data structure that represents a hex. This holds information about where the hex is in the grid.
    /// </summary>
    public class Hex : MonoBehaviour
    {
        private Vector3Int _position = Vector3Int.zero;
        
        public Vector3Int Position
        {
            get => _position;
            set
            {
                Debug.Assert(value.x + value.y + value.z == 0, "The coordinates being assigned are invalid.");
                _position = value;
            }
        }

        public int X 
        {
            get => _position.x;
            set => Position = new Vector3Int(value, _position.y, _position.z);
        }
        
        public int Y 
        {
            get => _position.y;
            set => Position = new Vector3Int(_position.x, value, _position.z);
        }
        
        public int Z 
        {
            get => _position.z;
            set => Position = new Vector3Int(_position.x, _position.y, value);
        }
    }
}