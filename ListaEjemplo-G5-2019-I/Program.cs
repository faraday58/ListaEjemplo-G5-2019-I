using System;
using System.Collections.Generic;
using Pokemones;

namespace ListaEjemplo_G5_2019_I
{
    class Program
    {
        static void Main()
        {
            List<Pokemon> pokemones = new List<Pokemon>();

            Pokemon pokemon1 = new Pokemon("Bulbasaur", "planta", 5, "fuego", true);
            Pokemon pokemon2 = new Pokemon("Charmander", "Fuego", 5, "Agua", true);
            Pokemon pokemon3 = new Pokemon("Mew", "Psiquico", 100, "Siniestro", true);

            pokemones.Add(pokemon1);
            pokemones.Add(pokemon2);
            pokemones.Add(pokemon3);
   
            foreach (Pokemon pkmn in pokemones)
            {
                Console.WriteLine("Tu pokemon : {0} Tipo: {1} nivel: {2} Debilidad: {3} sexo: {4}  ", pkmn.Nombre, pkmn.Tipo, pkmn.Nivel, pkmn.Debilidad, pkmn.Sexo);
            }


            Console.WriteLine("\n");
            pokemones.Remove(pokemon1);

            foreach (Pokemon pkmn in pokemones)
            {
                Console.WriteLine("Tu pokemon : {0} Tipo: {1} nivel: {2} Debilidad: {3} sexo: {4}  ", pkmn.Nombre, pkmn.Tipo, pkmn.Nivel, pkmn.Debilidad, pkmn.Sexo);
            }

            Console.WriteLine("Qué pokemon deseas eliminar?");
            string nombre= Console.ReadLine();

            for(int i=0; i<pokemones.Count;i++)
            {
                if(nombre==pokemones[i].Nombre)
                {
                    pokemones.Remove(pokemones[i]);
                }
            }

            foreach (Pokemon pkmn in pokemones)
            {
                Console.WriteLine("\nTu pokemon : {0} Tipo: {1} nivel: {2} Debilidad: {3} sexo: {4}  ", pkmn.Nombre, pkmn.Tipo, pkmn.Nivel, pkmn.Debilidad, pkmn.Sexo);
            }


        }
    }
}
