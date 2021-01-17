using Chinchillada.NodeGraph;
using UnityEngine;

namespace Function
{
    [CreateAssetMenu(menuName = "Scrobs/Graphs/Function Graph")]
    public class FunctionGraph : OutputGraph<FunctionNode>, IMathFunction
    {
        public float SampleFunction(float percentage) => this.OutputNode.SampleFunction(percentage);
    }
}