using UnityEngine;

namespace Function
{
    public class FunctionSubGraphNode : FunctionNode
    {
        [SerializeField] private FunctionGraph subGraph;
        
        public override float SampleFunction(float percentage)
        {
            return this.subGraph.SampleFunction(percentage);
        }
    }
}