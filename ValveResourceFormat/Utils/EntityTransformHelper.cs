using System.Globalization;
using System.Numerics;
using ValveResourceFormat.ResourceTypes;
using static ValveResourceFormat.ResourceTypes.EntityLump;

namespace ValveResourceFormat.Utils
{
    public static class EntityTransformHelper
    {
        public static void DecomposeTransformationMatrix(Entity entity, out Vector3 scaleVector, out Matrix4x4 rotationMatrix, out Vector3 positionVector)
        {
            var scale = entity.GetProperty<string>(CommonHashes.Scales);
            var position = entity.GetProperty<string>(CommonHashes.Origin);
            var anglesUntyped = entity.GetProperty(CommonHashes.Angles);

            if (scale == null || position == null || anglesUntyped == default)
            {
                scaleVector = default;
                rotationMatrix = Matrix4x4.Identity;
                positionVector = default;

                return;
            }

            scaleVector = ParseVector(scale);
            positionVector = ParseVector(position);

            var pitchYawRoll = anglesUntyped.Type switch
            {
                EntityFieldType.CString => ParseVector((string)anglesUntyped.Data),
                EntityFieldType.Vector => (Vector3)anglesUntyped.Data,
                _ => throw new NotImplementedException($"Unsupported angles type {anglesUntyped.Type}"),
            };

            var rollMatrix = Matrix4x4.CreateRotationX(pitchYawRoll.Z * MathF.PI / 180f);
            var pitchMatrix = Matrix4x4.CreateRotationY(pitchYawRoll.X * MathF.PI / 180f);
            var yawMatrix = Matrix4x4.CreateRotationZ(pitchYawRoll.Y * MathF.PI / 180f);

            rotationMatrix = rollMatrix * pitchMatrix * yawMatrix;
        }

        public static Matrix4x4 CalculateTransformationMatrix(EntityLump.Entity entity)
        {
            DecomposeTransformationMatrix(entity, out var scaleVector, out var rotationMatrix, out var positionVector);

            var scaleMatrix = Matrix4x4.CreateScale(scaleVector);
            var positionMatrix = Matrix4x4.CreateTranslation(positionVector);

            return scaleMatrix * rotationMatrix * positionMatrix;
        }

        public static Vector3 GetPitchYawRoll(EntityLump.Entity entity)
        {
            var anglesUntyped = entity.GetProperty("angles");

            if (anglesUntyped == default)
            {
                return default;
            }

            return anglesUntyped.Type switch
            {
                EntityFieldType.CString => ParseVector((string)anglesUntyped.Data),
                EntityFieldType.Vector => (Vector3)anglesUntyped.Data,
                _ => throw new NotImplementedException($"Unsupported angles type {anglesUntyped.Type}"),
            };
        }

        public static Vector3 ParseVector(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return default;
            }
            var split = input.Split(' ');

            if (split.Length != 3)
            {
                return default;
            }

            return new Vector3(
                float.Parse(split[0], CultureInfo.InvariantCulture),
                float.Parse(split[1], CultureInfo.InvariantCulture),
                float.Parse(split[2], CultureInfo.InvariantCulture));
        }
    }
}
