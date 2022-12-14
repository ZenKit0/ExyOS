﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExyOS.UserDefinitions {
    /// <summary>
    /// Defines unique identifer number for every entity
    /// </summary>
    [Serializable]
    internal class GroupIdentifier {
        public static int _id { get; private set; } = 0;
        public int Id { get; }

        public GroupIdentifier() {
            Id = _id;
            _id++;
        }
    }
}