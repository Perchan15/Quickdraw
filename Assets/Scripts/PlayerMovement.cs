using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //while(GameObject.Find("Player").transform.position)
        //System.Console.WriteLine($"{GameObject.Find("Player").transform.position}");
        Debug.Log($"{player.transform.position.y}");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.position;
        transform.position = Vector3.MoveTowards(a, target, speed);

        if (Countdown.started == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                GetComponent<AudioSource>().Play();

            }
        }

    }
}
