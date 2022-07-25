using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string TSN = "";
    [SerializeField] private float RT = 0.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("Reload", RT);
        }
    }
// Update is called once per frame
    private void Reload()
    {
        SceneLoader.LoadScene(TSN);
    }
}
