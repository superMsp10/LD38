using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

class BoostAmountIncrement : pickUps
{
    public int increment;

    public override void onPlayerContact(RigidbodyFirstPersonController p)
    {
        p.boostNum += increment;
        p.boostLeft = p.boostNum;
        base.onPlayerContact(p);
    }

}

