namespace Noise
{
    using Chinchillada.NodeGraph;
    using UnityEngine;

    [CreateAssetMenu(menuName = "Scrobs/Graphs/Noise Graph")]
    public class NoiseGraph : OutputGraph<NoiseNode>, INoise
    {
        public float Sample(float x, float y) => this.OutputNode.Sample(x, y);
    }
}