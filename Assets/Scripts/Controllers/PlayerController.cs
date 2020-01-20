using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField]
    private GameObject _player;
    
    private Movement _playerMovement;

    private Take _playerTake;
    
    public UnityAction<Vector3> PlayerMovement_Action;
    
    public UnityAction<GameObject> PlayerTake_Action;

    private void OnEnable()
    {
        _playerMovement = _player.GetComponent<Movement>();
        _playerTake = _player.GetComponent<Take>();
        InputController.Instance.PressMouseKeyLeft_Action += OnMouseLeftClickedToObject;
        PlayerMovement_Action += _playerMovement.OnMoveToTarget;
        PlayerTake_Action += _playerTake.OnTakeItem;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    }

    void OnMouseLeftClickedToObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.transform.CompareTag("Ground"))
                PlayerMovement_Action?.Invoke(hit.point);
            if (hit.transform.CompareTag("Item"))
                PlayerTake_Action?.Invoke(hit.transform.gameObject);
            
        }
    }
}
