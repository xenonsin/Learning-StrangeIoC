using strange.extensions.mediation.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class ObstacleMediator : Mediator
    {
        [Inject]
        public ObstacleView view { get; set; }

        //[Inject]
        //public DestroyObstacleSignal destroyObstacleSignal {get; set;}

        public override void OnRegister()
        {
            view.Init();
            
        }
    }

}