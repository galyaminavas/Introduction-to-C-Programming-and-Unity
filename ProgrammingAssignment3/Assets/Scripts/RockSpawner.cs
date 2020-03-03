using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;

    // saved for efficiency
    [SerializeField]
    Sprite rockSprite0;
    [SerializeField]
    Sprite rockSprite1;
    [SerializeField]
    Sprite rockSprite2;

    // spawn control
    const float SpawnDelay = 1;
    Timer spawnTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelay;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        int rocksCount = GameObject.FindGameObjectsWithTag("Rock").Length;
        // check for time to span a new rock and for current number of rocks on the screen
        if (spawnTimer.Finished && rocksCount < 3)
        {
            SpawnRock();

            // restart timer
            spawnTimer.Run();
        }
    }

    /// <summary>
    /// Spawns a new rock at the center of the screen
    /// </summary>
    void SpawnRock()
    {
        GameObject rock = Instantiate(prefabRock) as GameObject;
        // spawn at the center of the screen support
        Vector3 location = new Vector3(Screen.width / 2, Screen.height / 2, -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        rock.transform.position = worldLocation;

        // set random sprite for new rock
        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = rockSprite0;
        } else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = rockSprite1;
        } else
        {
            spriteRenderer.sprite = rockSprite2;
        }
        //switch (spriteNumber)
        //{
        //    case 0:
        //        spriteRenderer.sprite = rockSprite0;
        //        break;
        //    case 1:
        //        spriteRenderer.sprite = rockSprite1;
        //        break;
        //    case 2:
        //        spriteRenderer.sprite = rockSprite2;
        //        break;
        //}
    }
}
