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
            newTile.Position = Vector3Int.zero + new Vector3Int(1, 0, 0);
            
            LevelManager.Instance.AddTileToMap(newTile);;
        }
    }
}