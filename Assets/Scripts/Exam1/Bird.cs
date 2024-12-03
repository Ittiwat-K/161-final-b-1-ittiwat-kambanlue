using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption;
    private float weight;

    private void Start()
    {
        Init("Bird");
        DisplayName();
        MakeSound();
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{animalName} : Tweet Tweet!");
    }
}
