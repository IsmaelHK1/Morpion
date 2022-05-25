using System.Diagnostics;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Web;
using Morpion.Models;

namespace Morpion.Controllers
{
    public class Game : Controller
    {
        /* Placement dans un tableau*/


        /* A qui le tour*/
        public bool TeamBlue;
        public bool TeamRed;

        /* Définition model */
        private static readonly HttpClient client = new HttpClient();

        // [HttpPost]
        // [ActionName("Complex")]
        // public HttpResponse PostComplex()
        // {
        //     new BoardModel() board;
        //     board.Status = HttpUtility.HtmlEncode(update.Status);
        //     var request = WebRequest.Create(url);
        //     request.Method = "POST";
        // }

        [HttpGet]
        public void GetBoard(Guid id)
        {
            BoardModel board = new BoardModel();
            SetPos(Convert.ToInt32(id));
            Console.WriteLine(id);
        }
        //Set une position
        public void SetPos(int id)
        {
            Localization Position = new Localization();

            //Set une position
            switch (id)
            {
                case 1:
                    Position.PosX = 1;
                    Position.PosY = 1;
                    break;
                case 2:
                    Position.PosX = 2;
                    Position.PosY = 1;
                    break;
                case 3:
                    Position.PosX = 3;
                    Position.PosY = 1;
                    break;
                case 4:
                    Position.PosX = 1;
                    Position.PosY = 2;
                    break;
                case 5:
                    Position.PosX = 2;
                    Position.PosY = 2;
                    break;
                case 6:
                    Position.PosX = 3;
                    Position.PosY = 2;
                    break;
                case 7:
                    Position.PosX = 1;
                    Position.PosY = 3;
                    break;
                case 8:
                    Position.PosX = 2;
                    Position.PosY = 3;
                    break;
                case 9:
                    Position.PosX = 3;
                    Position.PosY = 3;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Update(Position, new BoardModel(), new TeamModel());
        }
        public void Update(Localization Position, BoardModel board, TeamModel team)
        {
            if (team.teamBlue.isTurn)
            {
                board.current[Position.PosX, Position.PosY] = 1;  // ERREUR ICI
            }
            else if (team.teamRed.isTurn)
            {
                board.current[Position.PosX, Position.PosY] = 2;
            }
            else
            {
                Console.WriteLine("ERROR : the boolean Team are null");
            }
        }
    }
}