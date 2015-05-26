//This allows us to run a coroutine outside a monobehavior.
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public interface IRoutineRunner
    {
        Coroutine StartCoroutine(IEnumerator method);
    }

}