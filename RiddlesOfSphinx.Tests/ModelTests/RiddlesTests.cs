using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiddlesOfSphinx.Models;
using System.Collections.Generic;
using System;

namespace RiddlesOfSphinx.Tests
{
    [TestClass]
    public class RiddlesTests
    {
        // First Test: Checking if my Riddles clas exists... Don't forget that this test passes whether our Riddles object exists or not
        [TestMethod]
        public void RiddlesConstructor_CreatesInstanceOfRiddle_Riddle()
        {
            Riddles newRiddle = new Riddles('A','B','C', 'D', 'E');
            Assert.AreEqual(typeof(Riddles), newRiddle.GetType());
        }

        // Second Test: Taking an answer to the sphinx question from user
        // nb=
        [TestMethod]
        public void GetFistAnswer_GetsFirstAnswer_Char()
        {
            // Arrange
            
            char myAns = 'A';
            Riddles newRiddle = new Riddles(myAns, 'B', 'C', 'D', 'E');

            // Act
            char answer = newRiddle.Answer1;

            // Assert
            Assert.AreEqual(myAns, answer);
        }
      
        // Third Test: Taking 2 questions answer
        // nb=
        [TestMethod]
        public void GetTwoAnswers_GetsTwoAnswers_Char()
        {
            // Arrange
            char myAns = 'A';
            char myAns2 = 'B';
            Riddles newRiddle = new Riddles(myAns, myAns2, 'C', 'D', 'E');

            // Act
            char answer = newRiddle.Answer2;

            // Assert
            Assert.AreEqual(myAns2, answer);
        }
      
        // Fourth Test: Taking 3 questions answer
        [TestMethod]
        public void GetThreeAnswers_GetsThreeAnswers_Char()
        {
            // Arrange
            char myAns3 = 'C';
            Riddles newRiddle = new Riddles('A','B',myAns3, 'D', 'E');

            // Act
            char answer = newRiddle.Answer3;

            // Assert
            Assert.AreEqual(myAns3, answer);
        }
      
        // Fifth Test: Taking 4 questions answer
        [TestMethod]
        public void GetFourAnswers_GetsFourAnswers_Char()
        {
            // Arrange
            char myAns4 = 'D';
            Riddles newRiddle = new Riddles('A','B','C', myAns4, 'E');

            // Act
            char answer = newRiddle.Answer4;

            // Assert
            Assert.AreEqual(myAns4, answer);
        }
      
        // Sixth Test: Taking 5 questions answer
        [TestMethod]
        public void GetFiveAnswers_GetsFiveAnswers_Char()
        {
            // Arrange
            char myAns5 = 'E';
            Riddles newRiddle = new Riddles('A','B','C', 'D', myAns5);

            // Act
            char answer = newRiddle.Answer5;

            // Assert
            Assert.AreEqual(myAns5, answer);
        }


    }    
}