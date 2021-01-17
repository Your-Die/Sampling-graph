﻿namespace Noise
{
    using Noise;
    using Chinchillada.Sampling;
    using Function;
    using UnityEngine;

    public class FunctionCombinerNode : NoiseNode
    {
        [SerializeField] [Input] private FunctionConnection functionX;
        [SerializeField] [Input] private FunctionConnection functionY;

        [SerializeField] private ISampleCombiner combiner;
        
        public override float Sample(float x, float y)
        {
            var sampleX = this.functionX.SampleFunction(x);
            var sampleY = this.functionY.SampleFunction(y);

            return this.combiner.Combine(sampleX, sampleY);
        }

        protected override void UpdateConnections()
        {
            base.UpdateConnections();

            this.functionX = this.GetInputValue(nameof(this.functionX), this.functionX);
            this.functionY = this.GetInputValue(nameof(this.functionY), this.functionY);
        }
    }
}