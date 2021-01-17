using UnityEngine;

namespace Function
{
    public abstract class CombinerNodeBase : FunctionNode
    {
        [SerializeField, Input] private FunctionConnection x;
        [SerializeField, Input] private FunctionConnection y;
        
        public override float SampleFunction(float percentage)
        {
            var sampleX = this.x.SampleFunction(percentage);
            var sampleY = this.y.SampleFunction(percentage);

            return this.CombineSamples(sampleX, sampleY, percentage);
        }

        protected abstract float CombineSamples(float sampleX, float sampleY, float percentage);

        protected override void UpdateConnections()
        {
            base.UpdateConnections();

            this.x = this.GetInputValue(nameof(this.x), this.x);
            this.y = this.GetInputValue(nameof(this.y), this.y);
        }
    }
}