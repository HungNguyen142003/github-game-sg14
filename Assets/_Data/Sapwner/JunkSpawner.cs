using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance => instance;//get

    public static string meteorieOne = "Meteorite_1";
    protected override void Awake()
    {
        base.Awake();
        if (JunkSpawner.instance != null) Debug.LogError("Only 1 JunkSpawner allow to exits");
        JunkSpawner.instance = this;
    }
}
