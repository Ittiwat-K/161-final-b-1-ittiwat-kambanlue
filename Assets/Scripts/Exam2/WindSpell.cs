using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpell : Spell
{
    private void Start()
    {
        Cast();
        SpellEffect();
    }

    public void Cast()
    {
        Debug.Log("Casting Wind Arrow");
    }

    public void SpellEffect()
    {
        Debug.Log("Enemy is stun.");
    }
}
