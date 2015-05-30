//Mediators provide a buffer bettwen views and the rest of the app
using strange.extensions.mediation.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class PlayerMediator : Mediator
    {
        //View
        [Inject]
        public PlayerView view { get; set; }

        //Signals
        [Inject]
        public GameInputSignal gameInputSignal { get; set; }
        [Inject]
        public DestroyPlayerSignal destroyPlayerSignal { get; set; }
        public override void OnRegister()
        {
            view.collisionSignal.AddListener(onCollision);
            gameInputSignal.AddListener(onGameInput);
            view.Init();
        }

        public override void OnRemove()
        {
            view.collisionSignal.RemoveListener(onCollision);
            gameInputSignal.RemoveListener(onGameInput);
        }

        private void onGameInput(int input)
        {
            view.SetAction(input);
        }

        private void onCollision()
        {
            destroyPlayerSignal.Dispatch(view, false);
            
        }
    }

}