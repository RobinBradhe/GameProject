using Assets.Interface;
using Assets.Models;

namespace Assets.Core
{
    public class Movement : IMovement
    //TODO: Movement<T> to get Animator or SpriteRenderer where T  : Baseclass?
    {
        private MovementHelper _movementHelper;
        public Movement()
        {
            _movementHelper = new MovementHelper();
        }

        void IMovement.MoveSprites(SpriteModel spriteModel)
        {
            _movementHelper.SetMovementModelKeyCode(spriteModel);
            if (spriteModel.SpriteRenderM != null)
            {
                //Movement of all sprites connected to SpritesMovingScript.
                _movementHelper.MoveSprites(spriteModel);
            }
        }

        void IMovement.Movement(MovementModel movementModel)
        {
            //Trying to do as little as possible if wrong key is pressed.
            movementModel = _movementHelper.SetMovementModelKeyCode(movementModel);
            if (movementModel == null)
                return;

            var switchModel = _movementHelper.GetCorrectAnimationName(movementModel);
            if (movementModel.AnimatorM != null)
            {
                //Do animation.
                _movementHelper.Animate(movementModel.AnimatorM, movementModel.AnimationName);
            }

        }
    }
}
