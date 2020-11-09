using UnityEngine;

namespace Assets.Models
{
    public class SpriteModel : MovementModel
    {
        public SpriteRenderer SpriteRenderM { get; set; }
        public float CurrentX { get; set; }
        public float CurrentY { get; set; }
        public float NextX { get; set; }
        public float NextY { get; set; }
    }
}
