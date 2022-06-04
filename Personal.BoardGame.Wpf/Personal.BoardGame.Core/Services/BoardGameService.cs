﻿using Personal.BoardGame.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.BoardGame.Core.Services
{
    public class BoardGameService
    {
        Random random = new Random();

        public List<NonTraversable> NonTraversables
        {
            get { return NonTraversables; }
        }

        public List<string> Traversables = new()
        {

        };
        
        public void CreateTraversables()
        {
            Traversables.Clear();
            //Traversables.Add("0-0", );
        }

        public void CreateNonTraversables()
        {
            NonTraversable nonTraversable = new NonTraversable(random.Next(0,19), random.Next(0,19));
            NonTraversables.Add(nonTraversable);
        }
    }
}
