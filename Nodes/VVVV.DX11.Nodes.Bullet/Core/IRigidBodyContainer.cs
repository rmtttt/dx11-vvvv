﻿using BulletSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVVV.Bullet.Core
{
    public interface IRigidBodyContainer : IRigidBodyCollection
    {
        int GetNewRigidBodyId();
        void Register(RigidBody body);
        event RigidBodyDeletedDelegate RigidBodyDeleted;
        event WorldResetDelegate WorldHasReset;
    }
}
