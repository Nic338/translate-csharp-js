// Put your code here
console.log("Do you believe in magic?");
console.log("------------------------");


const spells = [
    {
        Name: "Turn enemy into a newt",
        IsEvil: true,
        EnergyRequired: 5.1
    },
    {
        Name: "Conjure some gold for a local charity",
        IsEvil: false,
        EnergyRequired: 2.99
    },
    {
        Name: "Give a deaf person the ability to heal",
        IsEvil: false,
        EnergyRequired: 12.2
    },
    {
        Name: "Make yourself emporer of the universe",
        IsEvil: true,
        EnergyRequired: 100.0
    },
    {
        Name: "Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyRequired: 2921.5
    },
]
const displaySpellBook = (book) => {
    console.log(book.title)
    book.Spells.forEach(spell => {
        console.log(`   ${spell.Name}`)
    })
}
const goodSpellBook = () => {
    let goodBook = {
        title: "Good Book",
        Spells: spells.filter(spell => !spell.IsEvil),
    }
    return goodBook
}
const evilSpellBook = () => {
    let evilBook = {
        title: "Evil Book",
        Spells: spells.filter(spell => spell.IsEvil),
    }
    return evilBook
}
let goodBook = goodSpellBook(spells)
let evilBook = evilSpellBook(spells)

displaySpellBook(goodBook)
console.log()
displaySpellBook(evilBook)


