using UnityEngine;

namespace Assets.Models
{
    public class MovementModel : PlayerModel
    {
        //public  Player { get; set; }

        public Animator AnimatorM { get; set; }
        public string AnimationName { get; set; }

        public bool IsDefaultKeys { get; set; }
        public bool IsMoving { get; set; }
        public KeyCode Keycode { get; set; }
    }
}
