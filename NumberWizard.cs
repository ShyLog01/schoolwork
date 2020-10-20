using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1001;
    int min = 0;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        print("welcome to the number wizard");
        print("think of a number, but don't tell me what it is.");
        print("the highest number I can think of is " + max + " and the lowest number I can think of is " + min + ".");
        print("Is your number higher or lower than " + guess + "?");
        print("if the number is higher, press w, if the number is lower, press s, and if the I guessed your number, press space.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            print("I won!");
        else if(Input.GetKeyDown(KeyCode.W))
        {
            min = guess;
            guess = (min + max) / 2;
            print("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            max = guess;
            guess = (min + max) / 2;
            print("Is your number higher or lower than " + guess + "?");
        }
    }
}
