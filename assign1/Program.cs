using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
/* The game is made based on decisions, every decision can lead to a different path
 * There are 7 different endings, look on the readme.txt for the path for the endings
 * the choices should be writen as the question is 
 */
//beginning of the game
//Catinv is to help see which ending contain the Cat involved to help me understand and navegate throught the code easier
bool catinv = false;
Console.WriteLine("Welcome.\n" +
    "insert three different names.");
//Choice of names for all the main characters\\ These choices don't affect anything
String firstname = Console.ReadLine();
String secondname = Console.ReadLine();
String thirdname = Console.ReadLine();

Console.WriteLine("Very well, we shall start. \n" +
    firstname + " and " + secondname + " and " + thirdname + " are locked in a room, the outside world is contamined by radiation, it is unknown its effects \n" +
    "but the supplements in the room that " + firstname + secondname + thirdname + " are running out \n" +
    "now it is the time to make a choice \n" +
    "Go out and grab supplments or stay and pray");
String firstchoice = Console.ReadLine();
Console.WriteLine(firstchoice.ToLower());
if (firstchoice == "go out and grab supplements")
{
    Console.WriteLine("Before going out they must choose \n" +
        " use gas mask or not use gas mask");
    String maskchoice = Console.ReadLine();
    if (maskchoice == "use gas mask")
    {
        Console.WriteLine("On the way to the store for supplements " + thirdname + "spotted a cat, now a decision has to be made \n" +
            "ignore the cat or check on the cat");
        String catchoice = Console.ReadLine();
        if (catchoice == "ignore the cat")
        {
            // Ending #2
            Console.WriteLine("They went into the store \n" +
                "While grabbing supplements, a human figure ran after " + thirdname + ", and regrouped with the other two, and together \n" +
                "they tried to run \n" +
                secondname + firstname + "were captured and were devoured " + thirdname + " then left the store from the back door and \n" +
                "forced the door to leave, when the door opened...\n" +
                thirdname + " faced hundreds, thousands, maybe even more of humane figures that seemed infected by the radiation");
        }
        else if (catchoice == "check on the cat")
        {
            catinv = true;
            Console.WriteLine(thirdname + " got bit by the cat and ran away without telling the others \n" +
                "when walking beside " + secondname + " and " + firstname + "" + thirdname + " started to lose control over their own mind \n" +
                "losing completely conciousness, transforming and biting " + secondname + " but " + firstname + " ran away, and while running \n" +
                "away," + firstname + " had to choose \n" +
                "go left or go right ");
            String leftorright = Console.ReadLine();
            if (leftorright == "go left")
            {
                // Ending #3
                Console.WriteLine("On the attempt to escape, " + firstname + " tried to jump through the cash registers of the store, \n" +
                    " but due to the radiation, the structure was weak causing " + firstname + " fall under the pieces of the register \n" +
                    "where its body rest until this day \n" +
                    thirdname + "");
            }
            else if (leftorright == "go right")
            {
                
                Console.WriteLine(firstname + " saw a cat and decided to run towards the animal, and following the feline, " + firstname + "\n" +
                    "escaped the store and saw many infecteds, just like " + thirdname + " , and again " + firstname + " had to choose \n" +
                    "Follow the cat or run away");
                String followorrun = Console.ReadLine();
                if (followorrun == "follow the cat")
                {
                    // Ending #4
                    catinv = true;
                    Console.WriteLine("Upon following the cat, through the small thight streets of Burmecia " + firstname + " found a bunker \n" +
                        "that apparently the cat had counciously directed, where " + firstname + " found survivals of the radiation");
                            
                }
                else if (followorrun == "run away")
                {
                    // Ending #5
                    catinv = true;
                    Console.WriteLine("Upon trying to run away from the infecteds " + firstname + " was captured by " + thirdname + " when being \n" +
                        "devored, " + firstname + " looked at the building and in the area around, " + firstname + " noticed something, a sign \n" +
                        "something that was always there, for bad omens, wherever it was, a tragedy happened, upon looking at the very top of the \n" +
                        "store, " + firstname + "saw a cat.");
                }

            }

        }
    }
    else if (maskchoice == "not use gas mask")
    {
        // Ending #1
        Console.WriteLine("The radiation didn't seem to affect anyone \n" +
            "For everything they knew, everything was a placebo effect" );
    }
}
else if (firstchoice == "stay and pray")
{
    Console.WriteLine(firstname + " Died of starvation in the room \n" +
        "for this reason " + secondname + thirdname + " have fed on the dead body to keep themselves alive\n" +
        "however on an desperate attack " + secondname + " killed " + thirdname + " and fed on the dead body until there was nothing but bones\n" +
        "left, on the thin line between death and insanity " + thirdname + " must choose \n" +
        "stay and rot or go outside");
    String stayorgo = Console.ReadLine();
    if (stayorgo == "stay and rot")
    {
        //Ending #7
        catinv = true;
        Console.WriteLine(thirdname + "faced eminent death, and by final moment was spent praying and apologizing for the actions commited, and \n" +
            "laying on the floor, when eyes were closing as life was fading away, the door in front of" + thirdname + " begun opening \n" +
            "and the last view in life was...\n" +
            "a cat");
    }
    else if (stayorgo == "go outside")
    {
        // Ending #7
        Console.WriteLine("upon accepting fate, " + thirdname + "opened the door to let radiation end the miserable life left, but instead \n" +
            "nothing happenedm the only view was the clean air, as there was no radiation, the sacrifices and pain was all in vain. ");
    }
}
