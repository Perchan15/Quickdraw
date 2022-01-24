using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    //public Text countdownText;
    // Start is called before the first frame update
    public Text countdown;
    public static bool started;
    public float countdownNumber = 11f;
    public static bool winlose;


    void Start()
    {
        started = false;
        Invoke("Move", 2);
        InvokeRepeating("Decrease", 2, 1);
    }

    public void Move()
    {
        started = true;
        transform.position = new Vector3(0,4.25f,0);
    }

    public void Decrease()
    {
        if (countdownNumber > 1)
        {
            countdownNumber -= 1;
            countdown.text = $"{countdownNumber}";
        }
        else
        {

            winlose = false;
            SceneManager.LoadScene(sceneName:"EndGame");

        }
    }
}
