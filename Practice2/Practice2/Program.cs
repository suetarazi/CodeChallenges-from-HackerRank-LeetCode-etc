using System;
using System.Collections.Generic;
using static Practice2.Program;

namespace Practice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            string cityMap = "O__; _XT; ___";
            p.calculateDistance(cityMap);
        }

        /*
         * Complete the 'calculateDistance' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING cityMap as parameter.
         */

        //STRATEGY: CREATE A GRAPH OF VERTICES (ELEMENTS IN THE GIVEN STRINGS AS LOCATIONS) AND EDGES (ALL EDGES = 1).
        //STRATEGY: SEARCH THE GRAPH FOR O (OFFICERS STARTING POINT)
        //STRATEGY: GET NEIGHBORING VERTICES: IF NEIGHBOR != X, WALK THAT WAY FOR ONE STEP; INCREMENT DISTANCE++
        //STRATEGY: REPEAT UNTIL YOU ARRIVE AT T, THEN RETURN DISTANCE
        public class Vertex<T>
        {
            public T Value { get; set; }
            public Vertex(T value)
            {
                Value = value;
            }
        }

        public class Edge<T>
        {
            public int Weight { get; set; }
            public Vertex<T> Vertex { get; set; }
        }
        public class Graph<T>
        {
            public Dictionary<Vertex<T>, List<Edge<T>>> MapList { get; set; }
            private int _size;


            public Graph()
            {
                MapList = new Dictionary<Vertex<T>, List<Edge<T>>>();
            }
            public Vertex<T> AddLocation(T value)
            {
                Vertex<T> location = new Vertex<T>(value);
                MapList.Add(location, new List<Edge<T>>());
                _size++;
                return location;
            }

            public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
            {
                MapList[a].Add(
                    new Edge<T>
                    {
                        Weight = weight;
                Vertex = b;
            });
            }

        public List<Edge<T>> GetPath(Vertex<T> vertex)
        {
            return MapList[vertex];
        }
    }


    public static int calculateDistance(string cityMap)
    {
        //split cityMap into string array O__; _XT; ___;
        string[] mapStrings = cityMap.Split(";");

        //put each value of string arrays in a Graph as its own vertex. The distance between each value (aka the Weight of the Edge) is 1.
        foreach (string s in mapStrings)
        {
            int weight = 1;
            Console.WriteLine(s);
            Graph.AddLocation(s, weight);
        }

        //create a variable to measure the distance the officer will have to travel to get to the target incident
        int distance = 0;
        //find O (starting point of Officer) in your graph
        foreach (var vertex in MapList)
        {
            if (vertex.value == 'O')
            {
                distance = 0;
                while (vertex.value != T)
                {

                    vertex neighbor = GetPath(vertex);
                    if (neighbor != X)
                    {
                        distance++
                        }
                    vertex.value = neighbor;
                }
            }
        }

        return distance;

    }

}
}
