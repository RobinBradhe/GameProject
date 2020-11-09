using Assets.Models;
using UnityEngine;

namespace Assets.Interface
{
    public interface IMovement
    {
        void Movement(MovementModel movementModel);
        void MoveSprites(SpriteModel spriteModel);
    }
}
