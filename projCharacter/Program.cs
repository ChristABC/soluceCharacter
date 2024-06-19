using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using projCharacter;
using static System.Runtime.InteropServices.JavaScript.JSType;


class MainProgram
{
    public static void Main(string[] args)
    {
        Character j1 = new Character("Paul", "20", "40", "50");
        Character j2 = new Character();
        bool booleen = false;


        while (j1.lifePoints > 0 && j2.lifePoints > 0)
        {
            if (booleen == false)
            {
                Attaque(j1,j2);
                booleen = true;

            }
            else
            {
                Attaque(j2,j1);
                booleen = false;

            }
        }
            if (j1.lifePoints < 0 && j2.lifePoints >= 0)
            {
                Console.WriteLine("Le joueur "+j2.nameCharacter+"qui a gagné avec ce score: " + j2.lifePoints);

            }
            else if (j2.lifePoints < 0 && j1.lifePoints >= 0)
            {
            Console.WriteLine("Le joueur " +j1.nameCharacter+" a gagné avec ce score : " + j1.lifePoints);
            
            }
            else
            {
                Console.WriteLine("Vous avez fini égalité");
            
            }
        }
    
    public static void Attaque(Character j1, Character j2)
    {
        Console.WriteLine("Le "+ j1.nameCharacter +" attaque le "+j2.nameCharacter);
        j2.lifePoints = j2.lifePoints - (j1.lifeAttak - j2.lifeDef);
        Console.WriteLine("Le joureur "+j1.nameCharacter+" a pour nombre de points de vie : " + j1.lifePoints);
    }
 }