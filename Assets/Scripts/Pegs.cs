using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegs : MonoBehaviour
{
    [SerializeField, Range(8, 16)]
    int resolution = 8;

    [SerializeField]
    Transform pegPrefab;

    void Awake()
    {
        var position = Vector3.zero;

        
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        float gap = width * (3 / 4) / resolution;
        float vert = Mathf.Sqrt(gap - (gap / 2) * (gap / 2));
        
        
        
        for (float i = (float)resolution; i > 0; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Transform peg = Instantiate(pegPrefab);
                position.x = (j - i / 2) * 1;
                position.y = i * Mathf.Sqrt(3f/4f);

                peg.position = position;

                peg.SetParent(transform, false);
            }
        }
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
