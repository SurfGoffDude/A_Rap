using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDie : MonoBehaviour
{
    [SerializeField] GameObject droppedPrefab = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (droppedPrefab)
        {
            Instantiate(droppedPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject);
        Camera.main.GetComponent<TimedReload>().Invoke();
    }

}
