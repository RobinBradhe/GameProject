using Assets.Models;
using System;
using UnityEngine;

namespace Assets.Core
{
    //TODO: Static?
    public class MovementHelper
    {
        internal MovementModel GetCorrectAnimationName(MovementModel movementModel)
        {
            switch (movementModel.Keycode)
            {
                case KeyCode.A:
                    movementModel.AnimationName = movementModel.IsMoving ? "MC_Move_Left" : "MC_Idle_Left";
                    break;

                case KeyCode.D:
                    movementModel.AnimationName =  movementModel.IsMoving ? "MC_Move_Right" : "MC_Idle_Right";
                    break;

                case KeyCode.S:
                        movementModel.AnimationName = movementModel.IsMoving ? "MC_Move_Down" : "MC_Idle_Down";
                    break;

                case KeyCode.W:
                        movementModel.AnimationName = movementModel.IsMoving ? "MC_Move_Up" : "MC_Idle_Up";
                    break;

                default:
                    return movementModel;
            }

            return movementModel;
        }

        internal MovementModel SetMovementModelKeyCode(MovementModel movementModel)
        {
            //To heavy? Rebuild if I find better usage or if i can get GetKeyDown or Up.
            foreach (KeyCode vKey in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(vKey))
                {
                    movementModel.IsMoving = true;
                    movementModel.Keycode = vKey;
                    return movementModel;
                }
                else if (Input.GetKeyUp(vKey))
                {
                    movementModel.IsMoving = false;
                    movementModel.Keycode = vKey;
                    return movementModel;
                }
            }
            return null;
        }

        //private MovementModel SetMovementModelAnimationName(MovementModel movementModel, string animationName)
        //{
        //    if (!string.IsNullOrEmpty(animationName))
        //    {
        //        movementModel.AnimationName = animationName;
        //    }

        //    return movementModel;
        //}

        internal void MoveSprites(SpriteModel movementModel)
        {
            //movementModel.SpriteRenderM.transform.position = new Vector3(movementModel.CurrentX + 1f, movementModel.CurrentY + 1f);
            //spriteRenderM.material.SetFloat(spriteRenderM.name + switchmodel.X.ToString(), switchmodel.X);
            //GameObject.
            //movementModel.SpriteRenderM.
        }
        internal void Animate(Animator anim, string animationName)
        {
            anim.Play(animationName);
        }

    }
}
