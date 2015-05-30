using System.Linq.Expressions;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using System.Collections;

namespace  FlappyAnus
{
    public class ObstacleView : View
    {
        public float speed = 3f;

        private Rigidbody2D rb;

        //internal Signal exitScreenSignal = new Signal();

        internal void Init()
        {
            Debug.Log("helo");
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-speed, 0);
        }
    }

}