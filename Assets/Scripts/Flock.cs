using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    public int flockSize;

    private List<Agent> agentsInFlock;

    private void Awake()
    {
        agentsInFlock = new List<Agent>();
    }

    private void Start()
    {
        //create a flock of flocksize agents
        for (int i = 0; i < flockSize; i++)
        {
            Agent newAgent;

            //create and rename agent
            newAgent = AgentManager.Instance.CreateAgent(transform.position, this);
            newAgent.name = newAgent.name.Substring(0, newAgent.name.Length - 7) + i;

            //add to list
            agentsInFlock.Add(newAgent);
        }
    }
}
