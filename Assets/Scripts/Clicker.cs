using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour
{

    void OnMouseDown()
    {
        Debug.Log($"{Countdown.started}");
        if (Countdown.started == true)
        {
            Debug.Log("yo");
            KillScript.kills += 1;
            Destroy(gameObject);
            if (KillScript.kills == 4)
            {

                Countdown.winlose = true;
                SceneManager.LoadScene(sceneName:"EndGame");

            }
        }
    }
}
