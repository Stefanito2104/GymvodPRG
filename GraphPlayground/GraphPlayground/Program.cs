﻿using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            startNode.visited = true;
            Node currentNode = startNode;
            while(true)
            {
                Console.WriteLine("Aktuálně jsem v uzlu " + currentNode.index);
                Node neighborToVisit = null;
                foreach(Node neighbor in currentNode.neighbors)
                {
                    if (!neighbor.visited)
                    {
                        neighborToVisit = neighbor;
                        break;
                    }
                }
                if (neighborToVisit == null)
                {
                    if (currentNode == startNode)
                    {
                        Console.WriteLine("Jsem ve slepé uličce v uzlu " + currentNode.index);
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.cameFrom;
                    }
                }
                else
                {
                    Console.WriteLine("Jdu z uzlu " + currentNode.index + " do uzlu " + neighborToVisit.index);
                    neighborToVisit.visited = true;
                    neighborToVisit.cameFrom = currentNode;
                    currentNode = neighborToVisit;
                }
            }
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
