static void Main()
{
    List<string> insults = new List<string>
    {
        "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
    };
    int getRandomInsults()
    {
        int newInsults = new Random().Next(0, 7);
        return newInsults;
    }
    var randomInsults = new List<int>();
    while (randomInsults.Count < 3)
    {
        int insult = getRandomInsults();
        if(!randomInsults.Contains(insult))
        {
            randomInsults.Add(insult);
        }
    }
    for (var i = 0; i < randomInsults.Count; i++)
    {
        int index = randomInsults[i];
        Console.WriteLine(insults[index]);
    }
}
Main();
