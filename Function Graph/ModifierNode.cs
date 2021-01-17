using UnityEngine;

namespace Function
{
    using Chinchillada.Sampling;

    public class ModifierNode : FunctionNode
    {
        [SerializeField] [Input] private FunctionConnection input;

        [SerializeField] private ISampleModifier processor;
        
        [SerializeField] [HideInInspector] private bool hasInput;
        
        public override float SampleFunction(float percentage)
        {
            var sample = this.hasInput 
                ? this.input.SampleFunction(percentage)
                 : percentage;
            
            return processor.Process(sample, percentage);
        }

        protected override void UpdateConnections()
        {
            base.UpdateConnections();
            this.hasInput = this.GetPort(nameof(this.input)).IsConnected;

            this.input = this.hasInput
                ? this.GetInputValue<FunctionConnection>(nameof(this.input))
                : null;
        }
    }
}