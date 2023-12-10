﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFoundation.Extensions
{
    public static class Extensions
    {
        public static void PrintToFile(this char[,] twodimensionalarray)
        {
            var sb = new StringBuilder();
            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                for (var i = 0; i < twodimensionalarray.GetLength(0); i++)
                {
                    for (var j = 0; j < twodimensionalarray.GetLength(1); j++)
                    {
                        sb.Append(twodimensionalarray[i, j].ToString());
                    }
                    sb.AppendLine();
                }
                outputFile.WriteLine(sb.ToString());
            }
        }
        public static char[,] InitializeMap(this char[,] map, string[] otherMap)
        {
            for (int i = 0; i < otherMap.Length; i++)
            {
                for (int j = 0; j < otherMap[i].Length; j++)
                {
                    map[i, j] = otherMap[i][j];
                }
            }
            return map;
        }
        public static T[,] InitializeMapWithValue<T>(this T[,] map, T val)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = val;
                }
            }
            return map;
        }
    }
}
