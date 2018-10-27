using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexGrids
{
    public class HexCoordinates
    {
        public static Vector3Int North
        {
            get => new Vector3Int(0, 1, -1);
        }

        public static Vector3Int NorthEast
        {
            get => new Vector3Int(1, 0, -1);
        }
        
        public static Vector3Int NorthWest
        {
            get => new Vector3Int(-1, 1, 0);
        }
        
        public static Vector3Int South
        {
            get => new Vector3Int(0, -1, 1);
        }
        
        public static Vector3Int SouthEast
        {
            get => new Vector3Int(1, -1, 0);
        }
        
        public static Vector3Int SouthWest
        {
            get => new Vector3Int(-1, 0, 1);
        }
    }
}