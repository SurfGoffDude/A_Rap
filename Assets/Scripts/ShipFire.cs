using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject atackPrefab = null;
    [SerializeField] GameObject atack1 = null, atack2 = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(atackPrefab, transform.position, transform.rotation );
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            atackPrefab = atack1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            atackPrefab = atack2;
        }
    }
}
