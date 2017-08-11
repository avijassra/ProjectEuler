import * as _ from "lodash";

class Main {

    solve(): void {
        console.time("Problem 15")

        let gridSize = 2;
        let grid: number[][];

        for(var i= 0; i < gridSize +1; i++) {
            grid[i][gridSize] = 1;
            grid[gridSize][i] = 1;
        }

        for(var i = gridSize - 1; i >= 0; i--) {
            for(var j = gridSize - 1; j >= 0; j--) {
                grid[i][j] = grid[i][j+1] + grid[i+1][j]
            }
        }

        console.log(`Route options: ${grid[0][0]}`);
        console.timeEnd("Problem 15");
    }
}

(new Main()).solve();