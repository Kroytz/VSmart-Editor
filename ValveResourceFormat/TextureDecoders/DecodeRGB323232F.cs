using System.Numerics;
using System.Runtime.InteropServices;
using SkiaSharp;

namespace ValveResourceFormat.TextureDecoders
{
    internal class DecodeRGB323232F : ITextureDecoder
    {
        public void Decode(SKBitmap res, Span<byte> input)
        {
            using var pixels = res.PeekPixels();
            var span = pixels.GetPixelSpan<SKColor>();
            var offset = 0;
            var stride = 3 * sizeof(float);

            for (var i = 0; i < span.Length; i++)
            {
                var color = MemoryMarshal.Cast<byte, Vector3>(input.Slice(offset, stride))[0];
                offset += stride;

                span[i] = new SKColor(
                    (byte)(Common.ClampHighRangeColor(color.X) * 255),
                    (byte)(Common.ClampHighRangeColor(color.Y) * 255),
                    (byte)(Common.ClampHighRangeColor(color.Z) * 255),
                    255
                );
            }
        }
    }
}
