using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PinCounter : MonoBehaviour
{
    public GameObject[] pins;
    private int oldPinsCount;

    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
        //goes through all the pin tags i made and puts them in an array
    }

    void Update()
    {
        int currentPinsCount = 0;

        foreach (GameObject pin in pins)
        {
            

            if (pin.transform.up.y < 0.5f)
            {
                //checks that the pin is more than half way fallen over by
                //using the invisible y axis to see if its tipped more than 50 percent over
                currentPinsCount++;
            }
        if (currentPinsCount != oldPinsCount)
        {
                Debug.Log("Pins Fallen over: " + currentPinsCount);
                oldPinsCount = currentPinsCount;

                //checking if the nummber of pins changed from frame to frame
                //then priting the answer in the console and updating the count
        }
       }
   }

}