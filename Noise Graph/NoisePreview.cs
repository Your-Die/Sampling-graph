using System;
using Function;
using UnityEngine;

namespace Noise
{

    [Serializable]
    public class NoisePreview : TexturePreview<INoise>
    {
        [SerializeField] private Color color = Color.white;

        [SerializeField] private Vector2Int resolution = new Vector2Int(100, 100);

        public override Vector2Int Resolution => this.resolution;

        protected override void BuildTexture(Texture2D texture, INoise content)
        {
            var width = texture.width;
            var pixels = texture.GetPixels();
            
            for (var x = 0; x < width; x++)
            for (var y = 0; y < texture.height; y++)
            {
                var sampleX = (float) x / width;
                var sampleY = (float) y / texture.height;

                var sample = content.Sample(sampleX, sampleY);
                var index = width * y + x;
                
                var pixel = sample * this.color;
                pixels[index] = pixel;
            }
            
            texture.SetPixels(pixels);
        }
    }
}