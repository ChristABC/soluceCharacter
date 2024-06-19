using System;
using System.ComponentModel.Design;
using projCharacter;


class MainProgram
{
    public static void Main(string[] args)
    {
        Character j1 = new Character("Paul", "20", "40", "50");
        Character j2 = new Character();

    }


    public static float Attack(float x, float y)
    {
        if (x == 1 && y == 2)
        {
            Console.WriteLine("Le joueur j1 attaque le joueur 2.");

            j2.lifePoints = j1.lifeAttak - j2.lifeDef;

            return j2.lifePoints;
        }

        else if (x == 2 && y == 1)
        {

            Controle.WriteLine("Le joueur j2 attaque j1. ");
                j1.lifePoints = j2.lifeAttak - j1.lifeDef;
            return j1.lifePoints;
        }

        else
        {

            Console.WriteLine("Ecrire une valeur x et y différente entre 1 et 2.");
            Console.WriteLine("Si le joueur 1 attaque, en premiere valeur taper sinon 2. ");
            return 0;
        }
    }
}


  
