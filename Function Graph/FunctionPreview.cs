using System;
using UnityEngine;

namespace Function
{
    using Sirenix.OdinInspector;

    [Serializable]
    public class FunctionPreview : TexturePreview<IMathFunction>
    {
        [SerializeField]
        [OnValueChanged(nameof(ValidateResolution))]
        private int resolution = 100;

        [SerializeField] private Color color = Color.black;

        public override Vector2Int Resolution => Vector2Int.one * this.resolution;

        protected override void BuildTexture(Texture2D texture, IMathFunction function)
        {
            for (var x = 0; x < texture.width; x++)
            {
                var percentage = (float) x / texture.width;
                var sample     = function.SampleFunction(percentage);

                var y = (int) Mathf.Lerp(0, texture.height, sample);

                texture.SetPixel(x, y, this.color);
            }
        }

        private void ValidateResolution()
        {
            if (this.resolution < 0)
                this.resolution = 0;
        }
    }
}