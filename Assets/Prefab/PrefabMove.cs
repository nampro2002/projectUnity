using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Rigidbody2D objPhysic;
    PoolingSpawn poolingSpawn;
    void Start()
    {
        poolingSpawn = GameObject.Find("Pooling").GetComponent<PoolingSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if(poolingSpawn.timeGame > 10)
        {         
            objPhysic.gravityScale += 0.01f;
        }
    }
}
