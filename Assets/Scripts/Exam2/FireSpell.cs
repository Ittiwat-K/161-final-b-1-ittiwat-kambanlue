using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    
    private void Start()
    {
        Cast();
    }

    public void Cast()
    {
        Debug.Log("Casting Fireball");
    }
}
