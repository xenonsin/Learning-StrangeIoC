using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class KeyboardInput : IInput
    {
        [Inject(ContextKeys.CONTEXT_DISPATCHER)]
        public IEventDispatcher dispatcher { get; set; }

        [Inject]
        public IRoutineRunner routineRunner { get; set; }
        [Inject]
        public GameInputSignal gameInputSignal { get; set; }

        [PostConstruct]
        public void PostConstruct()
        {
            Debug.Log("hi input");
            routineRunner.StartCoroutine(Update());
        }

        protected IEnumerator Update()
        {
            while (true)
            {
                int input = GameInputEvent.NONE;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    input |= GameInputEvent.JUMP;
                }
                gameInputSignal.Dispatch(input);
                yield return null;
            }
        }
    }

}