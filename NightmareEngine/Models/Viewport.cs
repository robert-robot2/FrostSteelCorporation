

using Microsoft.AspNetCore.Razor.Hosting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using FrostSteelCorporation.NightmareEngine;
using FrostSteelCorporation.NightmareEngine.Enums;
using FrostSteelCorporation.NightmareEngine.Models;







namespace FrostSteelCorporation.NightmareEngine.Models

{
    public class Viewport
    {
        public PlayerPiece[,] Port { get; set; }

        public Player GameBegin = Player.Warrior;

        public bool GameComplete;

        public Viewport()
        {
            Reset(); 
        }




        public void Reset() 
        
        
        {


            Port = new PlayerPiece[9, 9];

            
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    Port[i, j] = new PlayerPiece();
                }
            }



        }



        //Given the coordinates of the space that was clicked...
        public void PieceClicked(int x, int y)
        {
            //If the game is complete, do nothing
            if (GameComplete) { return; }

            //If the space is not already claimed...
            PlayerPiece clickedSpace = Port[x, y];
            if (clickedSpace.Style == Player.Blank)
            {
                //Set the marker to the current turn marker (X or O), then make it the other player's turn
                clickedSpace.Style = GameBegin;
                
            }
        }

       







    }



}









