using UnityEngine;
using System.Collections;

public class StartingPlanet : MonoBehaviour
{
    public Animator animator;
    public GameObject cutsceneCamera;
    public Transform cutSceneTrans;
    Vector3 theifOrgPos;
    Transform theifOrgTrans;
    Person theif;

    public GameObject instructions;

    public WorldBuilder thisBuilder;

    public void EndAnimation()
    {
        animator.enabled = false;

        cutsceneCamera.SetActive(false);

        theif.transform.position = theifOrgPos;
        theif.transform.parent = theifOrgTrans;

        cutSceneTrans.gameObject.SetActive(false);
        theif.activated = true;
        thisBuilder.dialog.text = "";
        thisBuilder.player.SetActive(true);

        instructions.SetActive(true);

    }

    public void startAnimation()
    {
        instructions.SetActive(false);

        theif = thisBuilder.theif.GetComponent<Person>();
        theif.activated = false;


        theifOrgPos = thisBuilder.theif.transform.position;
        theifOrgTrans = thisBuilder.theif.transform.parent;

        theif.transform.parent = cutSceneTrans;
        theif.transform.localPosition = Vector3.zero;

        animator.enabled = true;

    }

    public void showDialog1()
    {
        thisBuilder.dialog.text = "That person stole your small snow globe. You must get it back!";

    }

    public void showDialog2()
    {
        thisBuilder.dialog.text = "...But what are the chances you will run into a stranger again?";

    }

}
