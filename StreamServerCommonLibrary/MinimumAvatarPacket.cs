﻿namespace CommonLibrary
{
    public class MinimumAvatarPacket
    {
        public readonly string PaketId;
        public readonly Vector3 Position;
        public readonly float RadY;
        public readonly Vector4 NeckRotation;

        public MinimumAvatarPacket(string paketId, Vector3 position, float radY, Vector4 neckRotation)
        {
            PaketId = paketId;
            Position = position;
            RadY = radY;
            NeckRotation = neckRotation;
        }
    }
}
