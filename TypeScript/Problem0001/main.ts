class Main {

    solve(): void {
        var sum = 0;

        console.time("Problem 1")

        for(let i = 0; i < 1000; i++) {
            if(i%3 === 0 || i%5 === 0) {
                sum += i;
            }
        }

        console.log(`Total: ${sum}`);

        console.timeEnd("Problem 1")
    }
}

(new Main()).solve();