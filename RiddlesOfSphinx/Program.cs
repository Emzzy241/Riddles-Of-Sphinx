using System;


namespace RiddlesOfSphinx.Models
{

    class Program
    {
        static void Main()
        {
            Riddles newRiddle  = new Riddles('A', 'B', 'C', 'D', 'E');

            Console.WriteLine("Welcome to the Riddles Of Sphinx Application");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rules: User Sphinx asks user questions, If the user answers correctly, the Sphinx is defeated. If the user is incorrect, the Sphinx eats the user.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 1");
            Console.WriteLine();



            Console.WriteLine("I help to reason and Everyone needs me to survive");
            Console.WriteLine("A. Brain");
            Console.WriteLine("B. Leg");
            Console.WriteLine("C. Hand");
            Console.WriteLine("D. Chest");
            Console.WriteLine("E. Nose");
            Console.WriteLine("Enter 'A' for Brain, 'B' for Leg, 'C' for Hand");
            string userAns1 = Console.ReadLine().ToUpper();
            char userAns1Char = char.Parse(userAns1);

            // =bn
            char myRealAns1 = newRiddle.Answer1;

            if(userAns1Char == myRealAns1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Yay. You defeated Sphinx in this round, be careful he might defeat you in the next round");
                Console.WriteLine();

                 Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Question 2");
                Console.WriteLine();

                // =bn
                Console.WriteLine("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?");
                Console.WriteLine("A. Ocean");
                Console.WriteLine("B. Echo");
                Console.WriteLine("C. Sound");
                Console.WriteLine("D. Music");
                Console.WriteLine("E. Tone");
                Console.WriteLine("Enter 'A' for Ocean, 'B' for Echo, 'C' for Sound, 'D' for Music, 'E' for Tone");
                string userAns2 = Console.ReadLine().ToUpper();
                char userAns2Char = char.Parse(userAns2);
            
                char myRealAns2 = newRiddle.Answer2;

                if (userAns2Char == myRealAns2)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay. You defeated Sphinx in round2, 3 rounds left to win Sphinx. Be careful!");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Question 3");
                    Console.WriteLine();

                    Console.WriteLine("I can be cracked, made, told, and played. What am I?");
                    Console.WriteLine("A. Brain");
                    Console.WriteLine("B. Echo");
                    Console.WriteLine("C. Joke");
                    Console.WriteLine("D. Laugh");
                    Console.WriteLine("E. Smile");
                    Console.WriteLine("Enter 'A' for Brain, 'B' for Echo, 'C' for Joke, 'D' for Laugh, 'E' for Smile");
                    string userAns3 = Console.ReadLine().ToUpper();
                    char userAns3Char = char.Parse(userAns3);
            
                    char myRealAns3 = newRiddle.Answer3;

                    if(userAns3Char == myRealAns3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Yay. You defeated Sphinx in round3, 2 rounds left to win Sphinx. Be careful!");
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Question 4");
                        Console.WriteLine();

                        Console.WriteLine("I have keys but no locks. I have space but no room. You can enter, but you can't go inside. What am I?");
                        Console.WriteLine("A. Table");
                        Console.WriteLine("B. Fan");
                        Console.WriteLine("C. Chair");
                        Console.WriteLine("D. Keyboard");
                        Console.WriteLine("E. Mouse");
                        Console.WriteLine("Enter 'A' for Table, 'B' for Fan, 'C' for Chair, 'D' for Keyboard, 'E' for Mouse");
                        string userAns4 = Console.ReadLine().ToUpper();
                        char userAns4Char = char.Parse(userAns4);

                        char myRealAns4 = newRiddle.Answer4;
                        if (userAns4Char == myRealAns4)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Yay. You defeated Sphinx in round4, 1 rounds left to win Sphinx. Be careful!");
                            Console.WriteLine();

                             Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Question 5");
                            Console.WriteLine();

                            Console.WriteLine("The person who makes it, sells it. The person who buys it never uses it. What is it?");
                            Console.WriteLine("A. House");
                            Console.WriteLine("B. Chair");
                            Console.WriteLine("C. Corpse");
                            Console.WriteLine("D. Spirit");
                            Console.WriteLine("E. Coffin");
                            Console.WriteLine("Enter 'A' for House, 'B' for Chair, 'C' for Corpse, 'D' for Spirit, 'E' for Coffin");
                            string userAns5 = Console.ReadLine().ToUpper();
                            char userAns5Char = char.Parse(userAns5);

                            char myRealAns5 = newRiddle.Answer5;

                            if (userAns5Char == myRealAns5)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Yay. You defeated Sphinx in all rounds, Sphinx has been completely defeated.");

                                Console.WriteLine("Would you like to play again, Enter 'Y' for yes and 'N' to quit application");
                                string userCont = Console.ReadLine().ToUpper();
                                Console.WriteLine();
                                if(userCont == "Y")
                                {
                                    Console.WriteLine("Playing game again");

                                    Console.WriteLine();
                                    Main();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }
                                else if (userCont == "N")
                                {
                                    Console.WriteLine("Goodbye my dear user");

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Sorry, I didn't get that, Lets try again");
                                    Console.WriteLine();
                                    Main();
                                    Console.WriteLine();
                                }
                            }
                            else if (userAns5Char != myRealAns5)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Awwwwww :( Sphinx defeated you in the 5th round, Let's go again");
                                Console.WriteLine();
                                Main();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Sorry, I didn't get that, Lets try again");
                                Console.WriteLine();
                                Main();
                                Console.WriteLine();
                            }

                        }
                        else if (userAns4Char != myRealAns4)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Awwwwww :( Sphinx defeated you in this round, Let's go again");
                            Console.WriteLine();
                            Main();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Sorry, I didn't get that, Lets try again");
                            Console.WriteLine();
                            Main();
                            Console.WriteLine();
                        }


                    }
                    else if (userAns3Char != myRealAns3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Awwwwww :( Sphinx defeated you in this round, Let's go again");
                        Console.WriteLine();
                        Main();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Sorry, I didn't get that, Lets try again");
                        Console.WriteLine();
                        Main();
                        Console.WriteLine();
                    }
                    

                }
                else if (userAns2Char != myRealAns2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Awwwwww :( Sphinx defeated you in this round, Let's go again");
                    Console.WriteLine();
                    Main();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Sorry, I didn't get that, Lets try again");
                    Console.WriteLine();
                    Main();
                    Console.WriteLine();
                }

            }
            else if(userAns1Char != myRealAns1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Awwwwww :( Sphinx defeated you in round2, You have to start from scratch");
                Console.WriteLine();
                Main();
                Console.WriteLine();

                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sorry, I didn't get that, Lets try again");
                Console.WriteLine();
                Main();
                Console.WriteLine();
            }


            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Question 2");
            // Console.WriteLine();

            // =bn
            // Console.WriteLine("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?");
            // Console.WriteLine("A. Ocean");
            // Console.WriteLine("B. Echo");
            // Console.WriteLine("C. Sound");
            // Console.WriteLine("D. Music");
            // Console.WriteLine("E. Tone");
            // Console.WriteLine("Enter 'A' for Ocean, 'B' for Echo, 'C' for Sound, 'D' Music, 'E' Tone");
            // string userAns2 = Console.ReadLine().ToUpper();
            
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Question 3");
            // Console.WriteLine();

            // Console.WriteLine("I can be cracked, made, told, and played. What am I?");
            // Console.WriteLine("A. Brain");
            // Console.WriteLine("B. Echo");
            // Console.WriteLine("C. Joke");
            // Console.WriteLine("D. Spirit");
            // Console.WriteLine("E. Shadow");
            // Console.WriteLine("Enter 'A' for Brain, 'B' for Echo, 'C' for Sound, 'D' for Spirit, 'E' for Shadow");
            // string userAns3 = Console.ReadLine().ToUpper();
            
            // =bn
            
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Question 4");
            // Console.WriteLine();

            // Console.WriteLine("I have keys but no locks. I have space but no room. You can enter, but you can't go inside. What am I?");
            // Console.WriteLine("A. Table");
            // Console.WriteLine("B. Fan");
            // Console.WriteLine("C. Chair");
            // Console.WriteLine("D. Keyboard");
            // Console.WriteLine("E. Mouse");
            // Console.WriteLine("Enter 'A' for Table, 'B' for Fan, 'C' for Chair, 'D' for Keyboard, 'E' for Mouse");
            // string userAns4 = Console.ReadLine().ToUpper();
            
            
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Question 5");
            // Console.WriteLine();

            // Console.WriteLine("The person who makes it, sells it. The person who buys it never uses it. What is it?");
            // Console.WriteLine("A. House");
            // Console.WriteLine("B. Chair");
            // Console.WriteLine("C. Corpse");
            // Console.WriteLine("D. Spirit");
            // Console.WriteLine("E. Coffin");
            // Console.WriteLine("Enter 'A' for House, 'B' for Chair, 'C' for Corpse, 'D' for Spirit, 'E' for Coffin");
            // string userAns5 = Console.ReadLine().ToUpper();
            
            // =bn
            
            
            
            // char userAns1Char = char.Parse(userAns1);
            // char userAns1Char = char.Parse(userAns1);
            // char userAns1Char = char.Parse(userAns1);
            // char userAns1Char = char.Parse(userAns1);



            // =bn

            // Riddles newRiddle = new Riddles(userAns1Char);



        }
    }   
}