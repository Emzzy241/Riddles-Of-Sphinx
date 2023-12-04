using System;

namespace RiddlesOfSphinx.Models
{
    public class Riddles
    {
        // My fields are readonly
        public char Answer1 { get; } = 'A';
        public char Answer2 { get; } = 'B';
        public char Answer3 { get; } = 'C';
        public char Answer4 { get; } = 'D';
        public char Answer5 { get; } = 'E';

        // The constructor
        public Riddles(char myAnswer1, char myAnswer2, char myAnswer3, char myAnswer4, char myAnswer5)
        {
            Answer1 = myAnswer1;
            Answer2 = myAnswer2;
            Answer3 = myAnswer3;
            Answer4 = myAnswer4;
            Answer5 = myAnswer5;
        }
        
           
    }
}