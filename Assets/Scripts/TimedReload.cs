using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedReload : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float time = 3;
    public void Invoke()
    {
        Invoke("Reload", time);
    }

    // Update is called once per frame
    private void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
