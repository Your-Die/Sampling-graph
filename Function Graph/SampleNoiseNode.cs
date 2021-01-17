namespace Function
{
    using Noise;
    using UnityEngine;

    public class SampleNoiseNode : FunctionNode
    {
        [SerializeField] [Input] private NoiseConnection noise;

        [SerializeField] [Input] private float otherAxis;

        [SerializeField] private INoiseSampler sampler;
        
        public override float SampleFunction(float percentage)
        {
            this.UpdateInput(ref this.otherAxis, nameof(this.otherAxis));
            return this.sampler.Sample(this.noise, this.otherAxis, percentage);
        }

        protected override void UpdateConnections()
        {
            base.UpdateConnections();
            
            this.noise = this.GetInputValue(nameof(this.noise), this.noise);
        }

        private interface INoiseSampler
        {
            float Sample(INoise noise, float otherAxis, float percentage);
        }
        
        private class SampleX : INoiseSampler
        {
            public float Sample(INoise noise, float otherAxis, float percentage)
            {
                return noise.Sample(percentage, otherAxis);
            }
        }
        
        private class SampleY : INoiseSampler
        {
            public float Sample(INoise noise, float otherAxis, float percentage)
            {
                return noise.Sample(otherAxis, percentage);
            }
        }
    }
}