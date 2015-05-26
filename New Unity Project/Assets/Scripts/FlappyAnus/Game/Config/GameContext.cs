
using strange.extensions.context.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class GameContext : SignalContext
    {
        public GameContext(MonoBehaviour contextView) : base(contextView)
        {
        }

        //Here we map bindings to fulfill dependencies

        protected override void mapBindings()
        {
            base.mapBindings();

            //Mapping Input
            injectionBinder.Bind<IInput>().To<KeyboardInput>().ToSingleton();

            //Signals (That are not bound to commands)
            injectionBinder.Bind<GameStartedSignal>().ToSingleton();
            injectionBinder.Bind<GameInputSignal>().ToSingleton();

            //Commands
            //All Commands get mapped to a Signal that executes them.
            if (Context.firstContext == this)
            {
                //Here we bind the StartSignal to the game start command
                //which is found in the Controllers folder
                commandBinder.Bind<StartSignal>()
                    .To<GameStartCommand>()
                    .Once();
            }
            commandBinder.Bind<DestroyPlayerSignal>().To<DestroyPlayerCommand>().Pooled();

            //Mediation
            mediationBinder.Bind<PlayerView>().To<PlayerMediator>();
        }

        protected override void postBindings()
        {
            base.postBindings();
        }
    }

}