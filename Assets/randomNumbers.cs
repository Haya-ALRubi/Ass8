using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int random = Random.Range(1, 21);
            if (random == 5)
            {
                continue;
            }
            else if (random == 15)
            {
                break;
            }
            else Debug.Log(random);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
