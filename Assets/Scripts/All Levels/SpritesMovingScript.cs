using Assets.Core;
using Assets.Interface;
using Assets.Models;
using UnityEngine;

public class SpritesMovingScript : MonoBehaviour, IMovement
{
    IMovement _movement;
    SpriteModel _spriteModel;
    Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    // Used like contructor.
    void Start()
    {
        _movement = new Movement();
        _spriteModel = new SpriteModel();
        _spriteModel.SpriteRenderM = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.None))
            return;
        MoveSprites(_spriteModel);


        //if (Input.GetKey(KeyCode.W))
        //{
        //    _movementModel.SpriteRenderM.transform.position = new Vector3(0, 0);
        //    //transform.position += Vector2.right;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{

        //}
        //if (Input.GetKey(KeyCode.A))
        //{

        //}
        //if (Input.GetKey(KeyCode.S))
        //{

        //}
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
