using HexGrids;
using Managers;
using UnityEngine;

namespace Temporary
{
    public class TempGameStart : MonoBehaviour
    {
        [SerializeField,Tooltip("Prefab that will get instantiated.")]
        private Hex _hexPrefab;
        
        public void Start()
        {
            Debug.Log("TempGameStart::Start()");
            CreateTiles();
            
        }

        private void CreateTiles()
        {
            Debug.Log("TempGameStart::CreateTiles()");
            Hex newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.North;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.NorthEast;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.NorthWest;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.South;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.SouthEast;
            LevelManager.Instance.AddTileToMap(newTile);
            
            newTile = Instantiate(_hexPrefab);
            newTile.Position = Vector3Int.zero + HexCoordinates.SouthWest;
            LevelManager.Instance.AddTileToMap(newTile);
        }
    }
}