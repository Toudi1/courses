using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class GameEventManager
    {
        //a new delegat type called GameEvent
        public delegate void GameEvent();

        //create two delegates varibles called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            //checking if OnGameStart event is not empty meaning that other methods already subscribed to it
            if (OnGameStart != null)
            {
                //print simple message.
                Console.WriteLine("The game has started...");
                //call the OnGameStart that will trigger all the methotd subscribed to this event
                OnGameStart();
            }
        }
        public static void TriggerGameOver()
        {
            //checking if OnGameStart event is not empty meaning that other methods already subscribed to it
            if (OnGameOver != null)
            {
                //print simple message.
                Console.WriteLine("The game is over...");
                //call the OnGameStart that will trigger all the methotd subscribed to this event
                OnGameOver();
            }
        }
    }
}
