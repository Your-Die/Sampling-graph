using System;
using Function;
using Sirenix.OdinInspector;
using UnityEngine;
using XNode;

namespace Noise
{
    public abstract class NoiseNode : ConnectionNode<NoiseConnection, INoise>, INoise
    {
        [SerializeField, PropertyOrder(int.MaxValue)]
        private NoisePreview preview;

        protected override INoise ConnectionSource => this;
        
        public abstract float Sample(float x, float y);

        protected override void RenderPreview() => this.preview.Preview(this);
    }
}