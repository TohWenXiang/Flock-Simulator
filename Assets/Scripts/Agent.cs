using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Agent : MonoBehaviour
{
    private Collider2D agentCollider;
    public Collider2D AgentCollider
    {
        get
        {
            return agentCollider;
        }
    }

    private void Awake()
    {
        agentCollider = GetComponent<Collider2D>();
    }

    public void Move(Vector2 direction)
    {
        transform.up = direction;
        transform.position += (Vector3)direction * Time.deltaTime;
    }
}
