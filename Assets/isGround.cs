using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGround : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool isGnd = false;
    public bool isGrnd() => isGnd;
    private Collider3D gndc = null;

    private void OnCollisionEnter3D(Collision3D collision)
    {
        
        if (gndc == null)
        {
            gndc = collision.collider;
            isGnd = true;
        }
    }

    private void OnCollisionExit3D(Collision3D collision)
    {
        if (gndc == collision.collider)
        {
            gndc = null;
            isGnd = false;
        }
    }
}
