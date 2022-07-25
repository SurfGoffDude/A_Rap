using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnObjact : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float timeBeforeStart = 1, timeInterval = 0.1f;
    [SerializeField] int repeat = 20;
    [SerializeField] GameObject spawnPrefab = null;
    void Start()
    {
        InvokeRepeating("SpawnWaveUnit", timeBeforeStart, timeInterval);
    }

    // Update is called once per frame
    void SpawnWaveUnit()
    {
        if (repeat > 0)
            repeat -= 1;
        var position = new Vector2(transform.position.x, Random.Range(-4.5f, 4.5f));
        Instantiate(spawnPrefab,  position, transform.rotation);
        if (repeat == 0)
        {
            CancelInvoke();
        }
    }
}
