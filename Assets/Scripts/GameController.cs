using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private List<Vector3> gridPositions = new List<Vector3>();
    public List<Floor> floor;
    public List<Wall> walls;
    public List<Enemy> enemies;
    public List<Resource> resources;

    public GameObject floorPrefab, wallPrefab, resourcePrefab, enemyPrefab;

    public Vector2 gridSize = new Vector2(8,8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void initGrid(){
        gridPositions.Clear();
        for (int i = 0; i < gridSize.x; i++){
            for(int j = 0; j < gridSize.y; j++){
                Vector3 pos = new Vector3(i, j, 0);
                gridPositions.Add(pos);
                Floor floorTile = Instantiate(floorPrefab, transform).GetComponent<Floor>();
                floorTile.transform.position = pos;
                floor.Add(floorTile);
                
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
