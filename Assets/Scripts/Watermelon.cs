using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : Fruit
{
    public override void OnFruitCombine()
    {
        this?.Invoke("PlayCombineParticleEffect",0);
        Debug.Log("Fruit Combined");
        
    }
}
