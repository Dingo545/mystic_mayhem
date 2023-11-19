using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : ProjectileSpellBehavior
{

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * spellData.Speed * Time.deltaTime; //set movement of BasicSpell
    }

}
