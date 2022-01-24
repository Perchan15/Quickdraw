using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour
{
    public Text killText;
    public static int kills = 0;

    void Start()
    {
        kills = 0;
        Invoke("Move", 2);
    }

    public void Move()
    {
        transform.position = new Vector3(0,3,0);
    }

    void Update()
    {
        killText.text = $"{kills}/4";
    }

}
