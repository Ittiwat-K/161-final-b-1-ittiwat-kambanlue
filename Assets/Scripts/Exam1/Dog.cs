using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;

    private void Start()
    {
        Init("Dog");
        DisplayName();
        MakeSound();
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{animalName} bark : Woof Woof!");
    }
}
