﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static List<Player> playerList = new List<Player>();

        static void Main(string[] args)
        {
            //Create Deck
            List<Cards> deck1 = Deck.CreateDeck();

            //Create Player and Dealer
            Dealer dealer = new Dealer();
            Player player = new Player("Player");

            //Add Player and Dealer to List<Players>
            playerList.Add(dealer);
            playerList.Add(player);

            //Initial Deal of two cards per player
            BlackJack.PlayGame.InitialDeal(playerList, deck1);

            //Play the game
            PlayGame.PlayerTurns(playerList, deck1);

            //PlayGame.DisplayFinal(playerList);
            
        }
    }
}
