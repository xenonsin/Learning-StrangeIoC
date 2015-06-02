using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using strange.extensions.command.impl;

namespace FlappyAnus
{
    public class CreateObstacleSpawnerCommand : Command
    {
        [Inject]
        public ISpawner spawner { get; set; }

        public override void Execute()
        {
            spawner.Start();
            
        }
    }

}