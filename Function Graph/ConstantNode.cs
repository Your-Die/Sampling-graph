using UnityEngine;

namespace Function
{
    public class ConstantNode : FunctionNode
    {
        [SerializeField] [Range(0, 1)] [Input] private float value;

        public override float SampleFunction(float _) => this.value;
    }
}