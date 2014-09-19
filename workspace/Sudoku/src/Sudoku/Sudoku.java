package Sudoku;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.util.Random;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import Sudoku.Frame1;
//import Sudoku.Generator;
import Sudoku.RandomNumber;

public class Sudoku {
	public static void main(String[] args) {
	//puts on random elements blank spot
		int easy=20,medium=40,hard=65;
		for (int i = 0; i < 65; i++) {
			 
			int	blankCell=RandomNumber.randInt(0, 8);
			int	blankRow=RandomNumber.randInt(0, 8);
			Generator.mask[blankRow][blankCell]=true;
			
		}
	
   // Run the GUI construction on the event-dispatching thread for thread safety
	   javax.swing.SwingUtilities.invokeLater(new Runnable() { public void run() {new Frame1();} });}
	   
	}

	


