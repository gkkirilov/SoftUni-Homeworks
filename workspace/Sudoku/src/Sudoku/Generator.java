package Sudoku;

public class Generator {

	public static boolean[][] mask = {
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false } };

	public static int[][] Gene(int rows, int cols) {
		int[][] puzzle = new int[rows][cols];

	
	
		 for (int i = 0; i < 9; i++)
         {
             for (int j = 0; j < 9; j++)
             {
                 puzzle[i][j] = (i * 3 + i / 3 + j) % 9 + 1;
                
             }
         }
		 //does permutation on the puzzle but keeps it true
		 int randNum1;
		 int randNum2;
		 int shuffleLevel = 20;
         for (int g = 0; g < shuffleLevel;g++ )
         {
        	 randNum1=RandomNumber.randInt(1, 9);
    		 randNum2=RandomNumber.randInt(1, 9);
             int xParm1, yParm1, xParm2, yParm2;
             xParm1 = yParm1 = xParm2 = yParm2 = 0;
             for (int i = 0; i < 9; i += 3)
             {
                 for (int k = 0; k < 9; k += 3)
                 {
                     for (int j = 0; j < 3; j++)
                     {
                         for (int z = 0; z < 3; z++)
                         {
                             if (puzzle[i + j][ k + z] == randNum1)
                             {
                                 xParm1 = i + j;
                                 yParm1 = k + z;
                             }

                             if (puzzle[i + j][ k + z] == randNum2)
                             {
                                 xParm2 = i + j;
                                 yParm2 = k + z;
                             }
                         }
                     }
                     puzzle[xParm1][ yParm1] = randNum2;
                     puzzle[xParm2][ yParm2] = randNum1;
                 }
             }

         }
		 
		return puzzle;
	}

	
}
