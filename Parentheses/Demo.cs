﻿using System;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            String expression;

            Console.Write("enter a expression with parentheses : ");
            expression = Console.ReadLine();

            if (IsValid(expression))
            
                Console.WriteLine("Valid expression ");
                else
                
                    Console.WriteLine("Invalid expression");
        }
        static bool IsValid(String expr)
        {
            StackA st = new StackA();
            char ch;

            for(int i = 0; i < expr.Length; i++)
            {
                
                if (expr[i] == '(' || expr[i] == '{' || expr[i] == '[')
                    st.Push(expr[i]);
                
                if(expr[i] == ')' || expr[i] == '}' || expr[i] == ']')
                    if (st.IsEmpty())
                    {
                        Console.WriteLine("Right parentheses are more than the left parentheses ");
                        return false;
                    }
                    else
                    {
                        ch = st.Pop();

                        if(!MatchParentheses(ch, expr[i]))
                        {
                            Console.WriteLine(" Mismatch parentheses are : ");
                            Console.WriteLine(ch + " and " + expr[i]);
                            return false;

                        }

                    }
            }
            if (st.IsEmpty())
            {
                Console.WriteLine("Balanced parentheses ");
                return true;
            }
            else
            {
                Console.WriteLine("Left parentheses are more than the right parentheses ");
                return false;
            }
            
        }
        static bool MatchParentheses(char leftPar,char rightPar)
        {
            if (leftPar == '[' && rightPar == ']')
            return true;
            if (leftPar == '{' && rightPar == '}')
                return true;
            if (leftPar == '(' && rightPar == ')')
                return true;

            return false;
        }




    }
    
    
    
}

