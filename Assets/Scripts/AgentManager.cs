using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *      Handles the creation of new agents, 
 *      searching of agents, 
 *      object pooling for killing and reviving, 
 */
public class AgentManager : MonoBehaviour
{
    //--------------------singleton----------------------
    private static AgentManager instance;
    public static AgentManager Instance
    {
        get
        {
            //if there is no instance of Agent Manager
            if (instance == null)
            {
                //create a new one
                GameObject go = new GameObject("Agent Manager");
                go.AddComponent<AgentManager>();
            }

            //return this instance or the one that was newly created
            return instance;
        }
    }
    //---------------------------------------------------

    private List<Agent> agentList;

    public Agent agentPrefab;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
        agentList = new List<Agent>();
    }

    public Agent CreateAgent(Vector2 pos, Flock targetFlock)
    {
        Agent newAgent;

        //create agent
        newAgent = Instantiate(agentPrefab, pos, Quaternion.identity, targetFlock.transform);

        //add agent to a list of agents that agent manager is tracking
        agentList.Add(newAgent);

        return newAgent;
    }

    public int GetPopulationCount()
    {
        return agentList.Count;
    }
}
