package Sudoku;
import java.awt.*;
import javax.swing.*;



				
public class Frame1  extends JFrame {
	 
	public static final long serialVersionUID = 1L;
	public static final int ROWS = 9; // ROWS by COLS cells
	   public static final int COLS = 9;
	   public static final int CELL_SIZE = 90; // Cell width/height
	   public static final int CANVAS_WIDTH = CELL_SIZE * COLS;
	   public static final int CANVAS_HEIGHT = CELL_SIZE * ROWS;
	// Game board
	   public int[][] cells;
	   public JTextField[][] tfCells;
	   
	   
	public Frame1() {
    Container cp = getContentPane();
    cp.setLayout(new GridLayout(ROWS, COLS));
    cells = new int[ROWS][COLS];
    tfCells = new JTextField[ROWS][COLS]; // allocate JTextField array
   int[][] grid= Generator.Gene(9, 9);
    // Create 9x9 JTextFields and place on the GridLayout
    for (int row = 0; row < 9; ++row) {
       for (int col = 0; col < 9; ++col) {
          tfCells[row][col] = new JTextField(); // allocate element of array
          cp.add(tfCells[row][col]);  // ContentPane adds JTextField
          int number = grid[row][col];
          for(int k=0;k<=8;k++){
			   for(int j=0;j<=8;j++){
				  if(grid[k][j]==0) Generator.mask[k][j]=true;
				
			   }
		   }
          if (Generator.mask[row][col]) {
             cells[row][col] = 0;
             tfCells[row][col].setText("");  // empty
             tfCells[row][col].setEditable(true);
            
             tfCells[row][col].setBackground(Color.WHITE);
             
             //win.getContentPane().add(pan,"Center");
           //  tfCells[row][col].setBorder(BorderFactory.createLineBorder(Color.green));
             
          } else {
             cells[row][col] = number;
             tfCells[row][col].setText(number + "");
             tfCells[row][col].setEditable(false);
             
          }
          tfCells[row][col].setHorizontalAlignment(JTextField.CENTER);
          tfCells[row][col].setFont(new Font("Monospaced", Font.BOLD, 20));
         
          tfCells[row][col].setBorder(BorderFactory.createLineBorder(Color.green));
          
       }
    }
   
   for (int i = 0; i < 9; i++) {
	for (int j = 0; j < 9; j++) {
		if((i<3 && j<3) || (i<3 && j>5))
		 tfCells[i][j].setBorder(BorderFactory.createLineBorder(Color.blue,2));
		if((i>5 && j<3) || (i>5 && j>5))
			 tfCells[i][j].setBorder(BorderFactory.createLineBorder(Color.blue,2));
		if(i>2 && i <6 && j>2 && j < 6) tfCells[i][j].setBorder(BorderFactory.createLineBorder(Color.blue,2));
	}
}
    cp.setPreferredSize(new Dimension(CANVAS_WIDTH, CANVAS_HEIGHT));

    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    pack();
    setTitle("Sudoku");
    setVisible(true);
	}
   
    
    
    
 }