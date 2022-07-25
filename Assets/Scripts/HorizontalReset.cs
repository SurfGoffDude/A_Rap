using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalReset : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float leftLimit = -11.5f, rightStart = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            transform.position = new Vector3(rightStart, transform.position.y, transform.position.z);
        }
    }
}
