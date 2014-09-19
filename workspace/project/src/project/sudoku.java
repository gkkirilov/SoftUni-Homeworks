package project;

import RandomNumber;

import java.util.Random;

public class sudoku {

    static final int max = 8;
    static final int min = 0;

    static final int digitMax = 9;
    static final int digitMin = 1;

    static final int easyMin = 20;
    static final int easyMax = 40;

  


    public static void main(String[] args) {

        int[][] grid = new int[9][9];

      

        Random random = new Random();
        
        int row = 0;
        int col = 0;

        int randomNumber = RandomNumber.randInt(1,9);
        int noOfCellsToBeGenerated = 0;

  /*    if ("easy".equals(option)) {
            noOfCellsToBeGenerated = random.nextInt((easyMax - easyMin) + 1) + easyMin;
        } 
        */
        for (int i = 0; i <= 8; i++) {
        	for(int j =0;j<9;j++){
          //  row = RandomNumber.randInt(1, 9);
          //  col = RandomNumber.randInt(1, 9);
          //  randomNumber = random.nextInt((digitMax - digitMin) + 1) + digitMin;

            if (grid[i][j] == 0 && noConflict(grid, i, j, randomNumber)) {
                grid[i][j] = randomNumber;
            } else {
                i--;
            }
        	}
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                System.out.print(grid[i][j] + "  ");
            }
            System.out.println();
        }

    }

    public static boolean noConflict(int[][] array, int row, int col, int num) {

        for (int i = 0; i < 9; i++) {
            if (array[row][i] == num) {
                return false;
            }
            if (array[i][col] == num) {
                return false;
            }
        }

       int gridRow = row - (row % 3);
        int gridColumn = col - (col % 3);
        for (int p = gridRow; p < gridRow + 3; p++) {
            for (int q = gridColumn; q < gridColumn + 3; q++) {
                if (array[p][q] == num) {
                    return false;
                    
                }
                
            }
            
        }
        
        return true;
    }
}