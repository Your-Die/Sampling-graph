using UnityEngine;

namespace Function
{
    public class CurveSamplerNode : FunctionNode
    {
        [SerializeField, Input] private AnimationCurve curve;

        public override float SampleFunction(float percentage) => this.curve.Evaluate(percentage);
    }
}