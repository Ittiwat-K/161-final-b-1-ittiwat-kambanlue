using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    protected float foodReqirement;

    public void Init(string name)
    {
        animalName = name;
    }

    public virtual void MakeSound()
    {

    }

    public void DisplayName()
    {
        Debug.Log($"This is a {animalName}");
    }
}
