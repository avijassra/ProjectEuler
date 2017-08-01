import * as _ from "lodash";

class Main {

    solve(): void {
        var sum = 0;

        console.time("Problem 2")

        var fibSeq = this.generateFibonacciSeries(0, 1, []);
        var sum = _.chain(fibSeq)
                    .filter(x => x % 2 === 0)
                    .sum()
                    .value();

        console.log(`Total: ${sum}`);
        console.timeEnd("Problem 2");
    }

    generateFibonacciSeries(n1: number, n2: number, list: number[]): Array<number> {
        let sum = n1 + n2;
        if(sum < 4000000) {
            list.push(sum);
            return this.generateFibonacciSeries(n2, sum, list);
        }
        return list;
    }
}

(new Main()).solve();