using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Specialized;

namespace project {

    class Program {
        static void Main() {
            
            Console.WriteLine("Please enter arguments"); //Здесь мы получаем значения от пользователя
            string arg = Console.ReadLine();           
           
            string pattern = @"([-]|[+])";  //Условие разбития строки на массив

            string[] calc = Regex.Split(arg, pattern); //Разбиваем строку string 

 
            for(var el = 0; el <= calc.Length-1; el++) {                            //Это все для обработки умножения
                if(calc[el] != @"\d" & calc[el] != "+" & calc[el] != "-") {  
                    string[] mass = Regex.Split(calc[el], "([*]|[/])");
                    int proiz = int.Parse(mass[0]);
                        for(int l = 0; l <= mass.Length-1; l++){
                            switch(mass[l]){
                                case "*":
                                proiz = int.Parse(mass[l+1])*proiz;
                                l++;
                                break;
                                case "/":
                                proiz = proiz/int.Parse(mass[l+1]);
                                l++;
                                break;
                            }
                        }
                            calc[el] = proiz.ToString();
 
                    }
            }
                        foreach(string el in calc) {
                Console.WriteLine("Перебор после произведения:" + el);

            }
               int result = int.Parse(calc[0]);
            for(var e = 0; e <= calc.Length-1; e++) {                                       //Это все сложение
                switch(calc[e]){
                case "+":
                result = result + int.Parse(calc[e+1]);
                e++;
                break;
                case "-":
                result = result - int.Parse(calc[e+1]);
                e++;
                break;
                }
 
            }
                            
            Console.WriteLine("Ответ:" + result);
        }

    }
                                    
}


