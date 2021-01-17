using Generators;
using UnityEngine;

namespace Function
{
    public class FunctionSamplerNode : GeneratorNodeWithPreview<float>
    {
        [SerializeField] [Range(0, 1)] [Input] 
        private float sample;

        [SerializeField] [Input] private FunctionConnection function;
        
        protected override float GenerateInternal() => this.function.SampleFunction(this.sample);

        protected override void UpdateInputs()
        {
            this.UpdateInput(ref this.sample, nameof(this.sample));
            this.UpdateInput(ref this.function, nameof(this.function));
        }
    }
}