using UnityEngine;

namespace Function
{
    public class LinearNode : FunctionNode
    {
        [SerializeField, Range(0, 1)] [Input] private float start;
        [SerializeField, Range(0, 1)] [Input] private float end = 1;

        public override float SampleFunction(float percentage)
        {
            return Mathf.Lerp(this.start, this.end, percentage);
        }
    }
}