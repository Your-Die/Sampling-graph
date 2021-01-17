using Sirenix.OdinInspector;
using UnityEngine;

namespace Function
{
    public abstract class FunctionNode : ConnectionNode<FunctionConnection, IMathFunction>, IMathFunction
    {
        [SerializeField][PropertyOrder(int.MaxValue)]
        private FunctionPreview preview;
        
        protected override IMathFunction ConnectionSource => this;

        
        public abstract float SampleFunction(float percentage);

        protected override void RenderPreview() => this.preview.Preview(this);
    }
}