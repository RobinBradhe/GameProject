using System;
using Assets.Core;
using Assets.Interface;
using Assets.Models;
using UnityEngine;

public class AnimationScript : MonoBehaviour, IMovement
{
    IMovement _movement;
    MovementModel _movementModel;
    // Start is called before the first frame update
    // Used like contructor.
    void Start()
    {
        _movement = new Movement();
        _movementModel = new MovementModel();
        _movementModel.AnimatorM = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if any key is pressed
        if(!Input.GetKey(KeyCode.None))
            Movement(_movementModel);
    }

    public void Movement(MovementModel movementModel)
    {
        _movement.Movement(movementModel);
    }

    public void MoveSprites(SpriteModel spriteModel)
    {
        _movement.MoveSprites(spriteModel);
    }
}
