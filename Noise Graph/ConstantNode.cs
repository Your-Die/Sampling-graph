namespace Noise
{
    using UnityEngine;

    public class ConstantNode : NoiseNode
    {
        [SerializeField] private float constant;
        
        public override float Sample(float x, float y)
        {
            return this.constant;
        }
    }
}