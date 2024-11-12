using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMoveScript : MonoBehaviour
{
    public int sceneBuildIndex;


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        if (other.tag == "Player")
        {
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

            if (sceneBuildIndex > 5)
            {
                SceneManager.LoadScene("VictoryScene", LoadSceneMode.Single);
            }

        }
    }
}
