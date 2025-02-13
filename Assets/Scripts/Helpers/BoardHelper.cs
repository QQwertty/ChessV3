using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Core
{
    public static class BoardHelper
    {
        
        public const int a1 = 0;
		public const int b1 = 1;
		public const int c1 = 2;
		public const int d1 = 3;
		public const int e1 = 4;
		public const int f1 = 5;
		public const int g1 = 6;
		public const int h1 = 7;

		public const int a8 = 56;
		public const int b8 = 57;
		public const int c8 = 58;
		public const int d8 = 59;
		public const int e8 = 60;
		public const int f8 = 61;
		public const int g8 = 62;
		public const int h8 = 63;

        public const string fileNames = "abcdefgh";
		public const string rankNames = "12345678";

        public static readonly Coordinate[] StaightCoorDirections = { new Coordinate(-1, 0), new Coordinate(1, 0), new Coordinate(0, 1), new Coordinate(0, -1) };
		public static readonly Coordinate[] DiagonalCoorDirections = { new Coordinate(-1, 1), new Coordinate(1, 1), new Coordinate(1, -1), new Coordinate(-1, -1) };
        public static readonly Coordinate[] KnightCoorDirections = 
		{ new Coordinate(2, 1), new Coordinate(1, 2), new Coordinate(-2, 1), new Coordinate(-1, 2), new Coordinate(2, -1), new Coordinate(1, -2), new Coordinate(-2, -1), new Coordinate(-1, -2)};

        public static readonly int[] StraightSquareDirections = {-1, 1, 8, -8};
        public static readonly int[] DiagonalSquareDirections = {7, 9, -9, -7};
        public static readonly int[] KnightSquareDirections = {15, 17, 10, 6, -15, -17, -10, -6};

        // Rank (0 to 7) of square 
		public static int RankIndex(int square)
		{
			return square >> 3;
		}

		// File (0 to 7) of square 
		public static int FileIndex(int square)
		{
			return square & 0b000111;
		}

        public static bool SquareInBounds(int square)
        {
           return (square < 64 && square >= 0) ? true : false;
        }

		public static int IndexFromCoord(int file, int rank)
		{
			return rank * 8 + file;
		}

		public static int IndexFromCoord(Coordinate coord)
		{
			return IndexFromCoord(coord.file, coord.rank);
		}

		public static Coordinate CoordFromIndex(int square)
		{
			return new Coordinate(FileIndex(square), RankIndex(square));
		}

		public static string SquareNameFromCoordinate(int file, int rank)
		{
			return fileNames[file] + "" + (rank + 1);
		}

		public static string SquareNameFromIndex(int square)
		{
			return SquareNameFromCoordinate(CoordFromIndex(square));
		}

		public static string SquareNameFromCoordinate(Coordinate coord)
		{
			return SquareNameFromCoordinate(coord.file, coord.rank);
		}

		public static int SquareIndexFromName(string name)
		{
			char fileName = name[0];
			char rankName = name[1];
			int file = fileNames.IndexOf(fileName);
			int rank = rankNames.IndexOf(rankName);
			return IndexFromCoord(file, rank);
		}
    }
}

