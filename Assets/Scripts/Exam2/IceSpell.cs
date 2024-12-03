using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
    }

    public void Cast(string enemyName)
    {
        Debug.Log("Casting Ice Shard");
    }
}
