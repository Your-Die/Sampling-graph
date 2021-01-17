using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Function
{
    public abstract class AggragatorNode : FunctionNode
    {
        [SerializeField, Input(dynamicPortList = true)]
        private List<FunctionConnection> inputs;
        
        public override float SampleFunction(float percentage)
        {
            var samples = this.inputs.Select(input => input.SampleFunction(percentage));
            
            return this.AggregateSamples(samples);
        }

        protected abstract float AggregateSamples(IEnumerable<float> samples);

        protected override void UpdateConnections()
        {
            const string fieldName = nameof(this.inputs);

            base.UpdateConnections();
            
            for (var index = 0; index < this.inputs.Count; index++)
            {
                var inputName = $"{fieldName} {index}";
                this.inputs[index] = this.GetInputValue(inputName, this.inputs[index]);
            }
        }
    }
}