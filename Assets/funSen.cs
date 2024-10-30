using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funSen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] fun = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monky", "Ball", "Bird" };
        int counter = 0;
        string all = "";
        while (counter < 7)
        {
            int randomFun = Random.Range(1, 8);
            all += fun[randomFun] + " ";
            counter++;
        }
        Debug.Log(all);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
