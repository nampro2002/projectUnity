using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PoolingSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject prefabApple;
    [SerializeField]
    GameObject prefabBanana;
    [SerializeField]
    GameObject prefabBomb;
    [SerializeField]
    int EnemyCount = 30;
    List<GameObject> Enemies;
    System.Random rnd;
    int indexprefab;
    int preIndex = 0;
    float time = 0;
    int index = 0;
    int pos = 0;
    float mode = 4;
    public  float timeGame  = 0;
    List<int> SpawnPos;
    int gameIndex = 0;
    int modeSpawn = 1;
    void Start()
    {
        SpawnPos = new List<int> { -9, -7,-5,-3, -1 , 1, 3,5,7,9 };
        rnd = new System.Random();
        Enemies = new List<GameObject>();
        for (int i = 0; i < EnemyCount; i++)
        {
            GameObject enemy = Instantiate(prefabApple);
            enemy.SetActive(false);
            Enemies.Add(enemy);
            GameObject enemyB = Instantiate(prefabBanana);
            enemyB.SetActive(false);
            Enemies.Add(enemyB);
            GameObject enemyBB = Instantiate(prefabBomb);
            enemyBB.SetActive(false);
            Enemies.Add(enemyBB);
        }       
    }

  
    // Update is called once per frame
    void Update()
    {
        // Increment the time.
        time += Time.deltaTime;
        timeGame += Time.deltaTime;
        if(timeGame > 10)
        {
            if(mode > 0.1f)
            {
                mode -= 0.5f;
                modeSpawn += 1;
            }
            timeGame = 0;
        }
        // If the time is greater than or equal to 5 seconds,
        // activate 5 enemies.
        if (time >= Random.Range(1, mode))
        {
            gameIndex = rnd.Next(Enemies.Count);
            GameObject enemy = Enemies[gameIndex];
            //foreach (GameObject enemy in Enemies)
            //{
            // If the index is less than the enemy count,
            // activate the enemy at the index.
                if (index < modeSpawn)
                {
                    if (enemy.activeSelf == false)
                    {
                        while (preIndex == pos)
                        {
                            pos = rnd.Next(SpawnPos.Count);
                        }
                        enemy.transform.position = new Vector3(Random.Range(-9, 9), 6, 0);
                        enemy.SetActive(true);
                        index++;
                    }
                }
            

            // Reset the time.
            time = 0;
            index = 0;
        }
    }


}