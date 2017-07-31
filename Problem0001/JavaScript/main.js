var Main = (function () {
    function Main() {
    }
    Main.prototype.solve = function () {
        var sum = 0;
        console.time("Problem 1");
        for (var i = 0; i < 1000; i++) {
            if (i % 3 === 0 || i % 5 === 0) {
                sum += i;
            }
        }
        console.log("Total: " + sum);
        console.timeEnd("Problem 1");
    };
    return Main;
}());
(new Main()).solve();
