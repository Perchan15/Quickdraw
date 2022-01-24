using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayScript : MonoBehaviour
{

    public Text howText;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(howText, 2);
        GetComponent<AudioSource>().Play();


    }

}

