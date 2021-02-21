using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using QRTools.Singletons;

namespace GameplayFramework
{
    public static class GF_Game
    {
        public delegate void GF_GameEventDelegate();
        public static GF_GameEventDelegate
            OnGameStartCallback,
            OnGameEndCallback,
            OnGamePauseOnCallback,
            OnGamePauseOffCallback;

        public static void StartGame()
        {
            OnGameStartCallback?.Invoke();
        }

        public static void EndGame()
        {
            OnGameEndCallback?.Invoke();
        }

        public static void PauseOn()
        {
            OnGamePauseOnCallback?.Invoke();
        }

        public static void PauseOff()
        {
            OnGamePauseOffCallback?.Invoke();
        }
    }
}