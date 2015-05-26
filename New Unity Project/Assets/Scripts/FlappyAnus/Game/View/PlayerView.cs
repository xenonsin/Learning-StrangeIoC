using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class PlayerView : View
    {
        internal Signal collisionSignal = new Signal();

        private Rigidbody2D rb;

        private int input;
        public float jumpForce = 300;

        //This is similar to calling Start() but this is called
        //In the mediator's OnRegister()
        internal void Init()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        internal void SetAction(int evt)
        {
            input = evt;
        }

        void FixedUpdate()
        {
            bool thrust = (input & GameInputEvent.JUMP) > 0;

            if (thrust)
            {
                //reset all velocity
                rb.velocity = Vector2.zero;
                //add jump force
                rb.AddForce(new Vector2(0, jumpForce));
            }
        }

        void OnTriggerEnter()
        {
            collisionSignal.Dispatch();
        }

    }

}