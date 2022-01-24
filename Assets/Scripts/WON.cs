using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Won(Countdown.winlose);
        Invoke("Menu2",2);
    }

    public void Menu2()
    {

        SceneManager.LoadScene(sceneName:"Menu");

    }

    public void Won(bool won)
    {

        if (won == true)
        {
            transform.position = new Vector3(0,3,0);
            GetComponent<AudioSource>().Play();

        }

    }

}
