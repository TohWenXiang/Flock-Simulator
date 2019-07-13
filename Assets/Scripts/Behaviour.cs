using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviour : ScriptableObject
{
    //context is for any surrounding objects such as an agent's neighbour or a obstacle.
    public abstract Vector2 CalculateMovement(Agent agent, List<Transform> context, Flock flock);
}
