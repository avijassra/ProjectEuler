class Main {

    solve(): void {
        var sum = 0;

        console.time("Problem 2")

        var lpf = this.CalculatePrimeFactor(600851475143, 2);

        console.log(`larget prime factor: ${lpf}`);
        console.timeEnd("Problem 3");
    }

    CalculatePrimeFactor(num: number, lpf: number): number {
        if(lpf > Math.sqrt(num)) {
            return num;
        } else if(num%lpf == 0) {
            return this.CalculatePrimeFactor(lpf, 2);
        } else {
            return this.CalculatePrimeFactor(num, (lpf+1));
        }
    }
}

(new Main()).solve();