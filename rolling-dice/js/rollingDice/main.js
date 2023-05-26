// Put your code here
console.log("Let's roll some dice, baby!")
console.log("---------------------------")

const d6 = {
    sides: 6,
    roll: function () {
        const randomNumber = Math.floor(Math.random() * this.sides) + 1;
        return randomNumber
    }
}

const dieOutcome = () => {
    let dieValue = d6.roll();
    let die = {
        value: dieValue,
        toString: function () {
            let dieString = "Unknown";
            if (this.value === 1) {
                dieString = "one";
            }
            else if (this.value === 2) {
                dieString = "two";
            }
            else if (this.value === 3) {
                dieString = "three";
            }
            else if (this.value === 4) {
                dieString = "four";
            }
            else if (this.value === 5) {
                dieString = "five";
            }
            else if (this.value === 6) {
                dieString = "six";
            }
            return dieString
        }
    }
    return die
};
    


for (let i = 0; i < 10; i++) {

    let die1 = dieOutcome()
    let die2 = dieOutcome()

    let message = `${die1} + ${die2} == ${die1.value + die2.value}`;
    if (die1.value === die2.value) {
        message += " DOUBLES!";
    }
    console.log(message)
}
