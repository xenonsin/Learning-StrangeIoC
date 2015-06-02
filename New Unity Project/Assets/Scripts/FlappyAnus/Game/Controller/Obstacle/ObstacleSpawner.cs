using System;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class ObstacleSpawner : ISpawner
    {
        [Inject]
        public CreateObstacleSignal createObstacleSignal { get; set; }

        [Inject]
        public IRoutineRunner routineRunner { get; set; }

        private float spawnSeconds = 3f;

        private bool running = false;

        [PostConstruct]
        public void PostConstruct()
        {
            //spawnSeconds = gameConfig.obstacleSpawnSeconds;
            //This is where you tie everything to the game config file.
        }

        public void Start()
        {
            running = true;
            routineRunner.StartCoroutine(Spawn());
        }

        public void Stop()
        {
            running = false;
        }

        IEnumerator Spawn()
        {
            while(running)
            {
                yield return new WaitForSeconds(spawnSeconds);
                createObstacleSignal.Dispatch();
            }
        }
    }
}