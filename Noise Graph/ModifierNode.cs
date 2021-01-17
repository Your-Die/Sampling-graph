namespace Noise
{
    using Chinchillada.Sampling;
    using UnityEngine;

    public abstract class ModifierNode : NoiseNode
    {
        [SerializeField] [Input] private NoiseConnection input;

        [SerializeField] private ISampleModifier modifier;

        [SerializeField] [HideInInspector] private bool hasInput;

        public override float Sample(float x, float y)
        {
            var sample = this.hasInput
                ? this.input.Sample(x, y)
                : 1;

            return this.modifier.Process(sample, x * y);
        }

        protected override void UpdateConnections()
        {
            base.UpdateConnections();
            this.hasInput = this.GetPort(nameof(this.input)).IsConnected;

            this.input = this.hasInput
                ? this.GetInputValue<NoiseConnection>(nameof(this.input))
                : null;
        }
    }
}