using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public static class Utils
    {
        public static void UpdatePosition(this RemoteClient client, Entity entity, Vector3D newPos, bool OnGround)
        {
            const short MaxDistance = short.MaxValue / (128 * 32);
            const short MinValue = short.MinValue / (128 * 32);
            bool OutOfDistance(double val) => val > MaxDistance || val < MinValue;
            var disX = entity.Position.X - newPos.X;
            var disY = entity.Position.Y - newPos.Y;
            var disZ = entity.Position.Z - newPos.Z;
            if (disX == 0 && disY == 0 && disZ == 0)
                return;

            if (OutOfDistance(disX) || OutOfDistance(disY) || OutOfDistance(disZ))
            {
                client.Broadcast(new EntityTeleport(entity, OnGround, newPos));
            }
            else
            {
                client.Broadcast(new EntityRelativeMove(entity, newPos, OnGround));
            }
        }
    }
}
