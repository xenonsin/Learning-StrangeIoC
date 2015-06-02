
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.pool.api;
using strange.extensions.command.impl;

namespace FlappyAnus
{
    public class CreateObstacleCommand : Command
    {
        [Inject(GameElement.OBSTACLE_POOL)]
        public IPool<GameObject> pool { get; set; }

        public override void Execute()
        {
            GameObject go = pool.GetInstance();
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - 5 * Random.value, 0);
        }
    }
}