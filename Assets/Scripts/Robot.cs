using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    Vector3 direction = Vector2.zero;

    static Vector3 north = new Vector3(0, 1, 0);
    static Vector3 east = new Vector3(1, 0, 0);
    static Vector3 south = new Vector3(0, -1, 0);
    static Vector3 west = new Vector3(-1, 0, 0);
    static Vector3[] directions = new Vector3[] {north,east,south,west};

    // Start is called before the first frame update
    void Start()
    {
        direction = RandomDirection();
    }

    public Vector2 RandomDirection() {
        return directions[(int)(Random.value*(directions.Length-0.1f))];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunProgram() {
        direction = RandomDirection();

        transform.position += direction;
        transform.position = GameController.instance.CheckBounds(GameController.instance.SnapToGrid(transform.position));
    }
}
