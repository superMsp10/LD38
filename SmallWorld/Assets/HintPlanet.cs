using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class HintPlanet : MonoBehaviour
{
    int hintType;
    public Text hintText;
    Person theif;

    // Use this for initialization
    void Start()
    {
        hintType = Random.Range(0, 2);
        hintText.text = "Hover over screen to reveal hint";

        theif = WorldBuilder.thisBuilder.theif;

        switch (hintType)
        {
            case 0:
                hintText.text = "The theif's colour is: " + theif.colourName;
                break;

            case 1:
                hintText.text = "The theif's planets is: " + theif.planetType;
                break;

            default:
                hintText.text = "The theif's is on a planet: ";
                break;
        }
    }


}
