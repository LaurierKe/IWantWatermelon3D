using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    private int ID_Index = -1;
    private void Awake()
    {
        instance = this;
    }
    public int GenerateID()
    {
        ID_Index++;
        return ID_Index;
    }

}
