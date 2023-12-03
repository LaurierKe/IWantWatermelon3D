using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fruit : MonoBehaviour
{
    public enum FRUIT_TYPE { CHERRY, STRAWBERRY,
        GRAPE, ORANGE, TOMATO, APPLE, PEAR, PEACH,
        PINEAPPLE, ASIAN_MELON, WATERMELON }

    [Header("Fruit Type")]
    public FRUIT_TYPE currentFruitType;

    [Header("Fruit Attributes")]
    public GameObject nextFruit;

    [Header("Particle FX")]
    [SerializeField] protected ParticleSystem onCombineEffect;

    protected int fruitID;

    void Start()
    {
        fruitID = SpawnManager.instance.GenerateID();    
    }
    public abstract void OnFruitCombine();

    public void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Fruit") &&
            collision.transform.GetComponent<Fruit>().currentFruitType.Equals(currentFruitType)) {
            OnFruitCombine();
            if(collision.gameObject.GetComponent<Fruit>().fruitID > fruitID)
            {
                Instantiate(nextFruit, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
    protected void PlayCombineParticleEffect()
    {
        if (onCombineEffect != null) Instantiate(onCombineEffect, transform.position, transform.rotation);
    }
}
