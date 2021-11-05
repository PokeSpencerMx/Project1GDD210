using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int sceneNumber = SceneManager.GetActiveScene().buildIndex;
            if (sceneNumber == 0)
            {
                SceneManager.LoadScene(1); //Remember this index is set in Build Settings -> Scenes.
            }
            else
            {
                SceneManager.LoadScene(0);
            }

        }
    }

}