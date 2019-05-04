using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    public int numberOfFlockToSpawn;
    public int minimumAgentCountPerFlock;
    public int maximumAgentCountPerFlock;

    private int populationSize;

    private void Start()
    {
        for (int i = 0; i < numberOfFlockToSpawn; i++)
        {
            Flock newFlock;
            //create a flock of size 10 centered around (0, 0)
            newFlock = FlockManager.Instance.CreateFlock(Vector2.zero, Random.Range(minimumAgentCountPerFlock, maximumAgentCountPerFlock));
            //rename flock
            newFlock.name = newFlock.name.Substring(0, newFlock.name.Length - 7) + i;
        }
    }
    
}
