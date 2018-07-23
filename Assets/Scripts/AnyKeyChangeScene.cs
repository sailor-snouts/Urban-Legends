using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyKeyChangeScene : MonoBehaviour
{
    [SerializeField]
    private string nextScene;

    public void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
