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
            position.x = Random.Range(-0.6f, 0.6f);
            position.y = pegsBoard.resolution - 1;
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
        /*
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        */
    }

    // Update is called once per frame
    void Update()
    {
        ballSpawner();
        GameObject gameObject = GameObject.FindGameObjectWithTag("Ball");
        if (gameObject.transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
