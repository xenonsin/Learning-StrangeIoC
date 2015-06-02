using strange.extensions.command.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    public class DestroyPlayerCommand : Command
    {
        [Inject]
        public PlayerView playerView { get; set; }

        public override void Execute()
        {
            //Debug.Log("You Died!");
            Application.LoadLevel(Application.loadedLevel);
        }
    }

}