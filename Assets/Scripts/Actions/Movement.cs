using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : Interaction
{
    private NavMeshAgent _agent;

    private Animator _animator;

    private Vector3 target;

    public float distance;

   // public InteractionType type;

    private void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //type = InteractionType.MOVE;
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoInteraction();
    }
    
    public void OnMoveToTarget(Vector3 target)
    {
        this.target = target;
        _agent.SetDestination(target);
    }

    public override bool CanInteract()
    {  
        return (_agent.remainingDistance > _agent.stoppingDistance); 
    }

    public override void DoInteraction()
    {
        _animator.SetBool("Walk", CanInteract());
        _agent.isStopped = !CanInteract();
    }
}
