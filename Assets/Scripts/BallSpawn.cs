using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField]
    Transform ballPrefab;

    [SerializeField]
    Pegs pegsBoard;

    void ballSpawner() // spawns ball on mouse click
    {
        
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            var position = Vector3.zero;
            Transform ball = Instantiate(ballPrefab);
            position.x = Random.Range(-0.3f, 0.3f);
            position.y = pegsBoard.resolution;
            ball.position = position;
            ball.SetParent(transform, false);
        }
    }

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballSpawner();
    }
}
