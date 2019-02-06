﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public static class TeleportManager
    {
        private static readonly ConcurrentDictionary<IEntity, List<int>> _ids = new ConcurrentDictionary<IEntity, List<int>>();
        private static readonly Random _rnd = new Random();

        public static int GenerateId(IEntity entity)
        {
            var v = _rnd.Next();
            _ids.AddOrUpdate(
                entity,
                new List<int>() { v },
                (oldEntity, oldList) =>
                {
                    if (oldEntity == entity)
                        oldList.Add(v);
                    return oldList;
                });
            return v;
        }

        public static bool AcceptId(IEntity entity, int id) 
            => _ids.TryGetValue(entity, out var ids) && ids.Remove(id);
    }
}
