using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAtLife : MonoBehaviour
{
    [SerializeField] float life_time = 0.1f;

    public void Des()
    {
        Destroy(gameObject, life_time);
    }
}
