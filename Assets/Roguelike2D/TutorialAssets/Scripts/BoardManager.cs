using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public int width;
    public int height;
    public Tile[] tiles;
    private Tilemap board;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        board = GetComponentInChildren<Tilemap>();
        Vector3Int coordinate = new Vector3Int(0,0,0);
        board.SetTile(coordinate, tiles[0]);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
