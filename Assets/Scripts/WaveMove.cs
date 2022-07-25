using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float power = 1, time = 2;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void TurnOn()
    {
        InvokeRepeating("ChangeDirection", 0, time);
    }

    void ChangeDirection()
    {
        rb.velocity = new Vector2 (rb.velocity.x, power);
        power = -power;
    }
    // Update is called once per frame
    public void TurnOff()
    {
        enabled = false;
        CancelInvoke();
    }
    
}
