using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public int playerSpeed;
    public Text Bonus;
    public int score;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, playerSpeed*Time.deltaTime, 0);
        }

        if (Input.GetKey("s"))
        {
            transform.position -= new Vector3(0, playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "Coin")
        {
            score += 5;
            Bonus.text = "Bonus :" + " " + score.ToString();
            Destroy(player.gameObject);
        }
        
        if (player.gameObject.tag == "Meteor")
        {
            score -= 1;
            Bonus.text = "Bonus :" +" " + score.ToString();
            Destroy(player.gameObject);
        }
    }
}

