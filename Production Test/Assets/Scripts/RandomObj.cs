using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObj : MonoBehaviour
{
    public GameObject Coin;
    public GameObject Meteor;
    float rndX;
    float rndY;
    int ob;
    void Start()
    {
        
    }

    void Update()
    {
        ob++;
        rndX = Random.Range(8.4f, -8.4f);
        rndY = Random.Range(3.3f, -3.3f);
        if(ob <9)
        {
            Instantiate(Meteor, new Vector2(rndX, rndY), Meteor.transform.rotation);
        }
        if(ob <5)
        {
            Instantiate(Coin, new Vector2(rndX, rndY), Coin.transform.rotation);
        }

    }
}
