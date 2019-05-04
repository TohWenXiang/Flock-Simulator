using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    //--------------------singleton----------------------
    private static FlockManager instance;
    public static FlockManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("Flock Manager");
                go.AddComponent<FlockManager>();
            }

            return instance;
        }
    }
    //---------------------------------------------------

    public Flock flockPrefab;
    public Transform populationContainer;

    private List<Flock> flockList;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
        flockList = new List<Flock>();
    }

    public Flock CreateFlock(Vector2 pos, int flockSize)
    {
        Flock newFlock;

        //create flock
        newFlock = Instantiate(flockPrefab, pos, Quaternion.identity, populationContainer);

        //define its flock size
        newFlock.flockSize = flockSize;

        //add flock to the list of flock that flock manager is tracking
        flockList.Add(newFlock);

        return newFlock;
    }

    public int GetFlockCount()
    {
        return flockList.Count;
    }
}
