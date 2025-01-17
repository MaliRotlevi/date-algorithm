﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacenyList
    {

    
        private Dictionary<string, Vertex<string>> cities;
        public  AdjacenyList()
        {
            this.cities = new Dictionary<string, Vertex<string>>();
        }
        public void AddCity(string city)
        {
            cities.Add(city, new Vertex<string>(city,null,0));
        }
        public void AddNeighbor(string city,string neighbor,int dist)
        {
            cities[city].AddNeighbor(neighbor, dist);
            cities[neighbor].AddNeighbor(city, dist);
        }
    }
}
