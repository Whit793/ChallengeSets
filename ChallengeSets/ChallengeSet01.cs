﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double Subtract(double minuend, double subtrahend)
        {
            throw new NotImplementedException();
        }

        public int Add(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            return (factor1 * factor2);
        }

        public string GetGreeting(string nameOfPerson)
        {
            return (nameOfPerson == "") ? "Hello!" : $"Hello, {nameOfPerson}!";
        }
        public string GetHey()
        {
            return "HEY!";
        }
    }
}
