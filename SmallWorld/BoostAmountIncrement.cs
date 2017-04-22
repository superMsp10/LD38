using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

class BoostAmountIncrement : pickUps
{
    public int incementAmount;

    public override void onPlayerContact(RigidbodyFirstPersonController p)
    {
       
        base.onPlayerContact(p);
    }

}

