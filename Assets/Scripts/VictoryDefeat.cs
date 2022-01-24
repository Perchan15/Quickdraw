using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryDefeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Lost(Countdown.winlose);
        Invoke("Menu",2);
    }

    public void Menu()
    {

        SceneManager.LoadScene(sceneName:"Menu");

    }

    public void Lost(bool won)
    {
        Debug.Log("hello");
        if (won == false)
        {
            transform.position = new Vector3(0,3,0);
            GetComponent<AudioSource>().Play();
        }

    }

}
