namespace Function
{
    using UnityEngine;

    public class BezierNode : FunctionNode
    {
        [SerializeField] private float b;
        [SerializeField] private float c;
        
        public override float SampleFunction(float percentage)
        {
            var flipped = 1 - percentage;
            var flippedSquared = flipped * flipped;

            var percentageSquared = percentage * percentage;
            var percentageCubed = percentageSquared * percentage;

            return (3f * this.b * flippedSquared * percentage) + 
                   (3f * this.c * flipped * percentageSquared) + 
                   percentageCubed;
        }
    }
}