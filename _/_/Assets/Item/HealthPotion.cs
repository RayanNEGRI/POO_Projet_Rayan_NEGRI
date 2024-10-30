using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    public EntityHealth entityHealth;

    public override void Use(PickUpItem pui)
    {
        base.Use(pui);
        Debug.Log("Le Joueur reçoit de la vie");
        entityHealth.AddVie(20);
    }

}
