class Main {
    private gridSize = 20;
    private grid: number[][] = [];
        

    solve(): void {
        console.time("Problem 15")

        for(var i= 0; i < this.gridSize +1; i++) {
            if(!this.grid) {
                this.grid = [];
            }

            if(!this.grid[i]) {
                this.grid[i] = [];
            }

            if(!this.grid[this.gridSize]) {
                this.grid[this.gridSize] = [];
            }

            this.grid[i][this.gridSize] = 1;
            this.grid[this.gridSize][i] = 1;
        }

        for(var i = this.gridSize - 1; i >= 0; i--) {
            for(var j = this.gridSize - 1; j >= 0; j--) {
                this.grid[i][j] = this.grid[i][j+1] + this.grid[i+1][j]
            }
        }

        console.log(`Route options: ${this.grid[0][0]}`);
        console.timeEnd("Problem 15");
    }
}

(new Main()).solve();