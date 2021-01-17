namespace Function
{
    using Chinchillada.Sampling;
    using UnityEngine;

    public class CombinerNode : CombinerNodeBase
    {
        [SerializeField] private ISampleCombiner combiner;

        protected override float CombineSamples(float sampleX, float sampleY, float percentage)
        {
            return this.combiner.Combine(sampleX, sampleY);
        }
    }
}