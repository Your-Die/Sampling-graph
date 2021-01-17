namespace Noise
{
    using Chinchillada.Sampling;
    using UnityEngine;

    public class CombinerNode : NoiseNode
    {
        [SerializeField] [Input] private NoiseConnection noiseA;
        [SerializeField] [Input] private NoiseConnection noiseB;

        [SerializeField] private ISampleCombiner combiner;
        
        public override float Sample(float x, float y)
        {
            var sampleA = this.noiseA.Sample(x, y);
            var sampleB = this.noiseB.Sample(x, y);

            return this.combiner.Combine(sampleA, sampleB);
        }

        protected override void UpdateConnections()
        {
            base.UpdateConnections();

            this.noiseA = this.GetInputValue(nameof(this.noiseA), this.noiseA);
            this.noiseB = this.GetInputValue(nameof(this.noiseB), this.noiseB);
        }
    }
}