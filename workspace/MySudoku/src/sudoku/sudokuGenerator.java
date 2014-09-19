package sudoku;

public class sudokuGenerator {
	public static void main(String)
	private int[][] generateSolution(int[][] game, int index) {
	    if (index > 80)
	        return game;

	    int x = index % 9;
	    int y = index / 9;

	    ArrayList<Integer> numbers = new ArrayList<Integer>();
	    for (int i = 1; i <= 9; i++)
	        numbers.add(i);
	    Collections.shuffle(numbers);

	    while (numbers.size() > 0) {
	        int number = getNextPossibleNumber(game, x, y, numbers);
	        if (number == -1)
	            return null;

	        game[y][x] = number;
	        int[][] tmpGame = generateSolution(game, index + 1);
	        if (tmpGame != null)
	            return tmpGame;
	        game[y][x] = 0;
	    }

	    return null;
	}
}
