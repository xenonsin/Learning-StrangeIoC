using strange.extensions.signal.impl;
using UnityEngine;
using System.Collections;

namespace FlappyAnus
{
    //Game
    public class GameStartedSignal : Signal { }

    //Player
    public class CreatePlayerSignal : Signal { }

    //ShipView - reference to the player's ship
    //bool - false indicates destruction. true indicates cleanup at end of level
    public class DestroyPlayerSignal : Signal<PlayerView, bool> { }

    //Vector3  Position of the obstacle
    public class CreateObstacleSignal : Signal<Vector3> { }

}