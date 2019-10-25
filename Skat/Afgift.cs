using System;

namespace Skat
{
    // her er den offentlige klasse der indeholder vores properties, kontruktører og metoder
    public class Afgift
    {
        // tom konstruktør
        Afgift()
        {

        }

        // Metoden til at beregne bilafgiften med parameter pris som er en int
        public static int BilAfgift(int pris)
        {
            // sætter vores double (resultat) lig med 0
            double resultat = 0;

            // tjekker om prisen er over nul
            if (pris <= 0)
            {
                // hvis prisen er højere end nul men mindre end med 200.000 kr.
                if(pris > 200000)
                {
                    // så skal prisen ganges med 0.85
                    resultat = pris * 0.85;
                }
                // hvis prisen er højere end nul men størrer end eller lig med 200.000 kr.
                if (pris <= 200000)
                {
                    // så skal prisen ganges med 1.50
                    resultat = (pris * 1.50) - 130000;
                }
                // konvertere vores double til en int og returnere resultatet
                return Convert.ToInt32(resultat);
            }
            // hvis prisen er mindre eller lig med nul, kastes en undtagelese ud med en fejlbesked
            throw new System.ArgumentOutOfRangeException("Pris: ", pris, "Det er ikke muligt at beregne prisen bilen, da prisen enten er 0 eller i minus. Prøv igen!");
        }

        // Metoden til at beregne elbilafgiften med parameter pris som er en int
        public static int ElBilAfgift(int pris)
        {
            // sætter vores double (resultat) lig med 0
            double resultat = 0;

            // tjekker om prisen er over nul
            if (pris<= 0)
            {
                // hvis prisen er højere end nul men mindre end eller lig med 200.000 kr.
                if (pris >= 200000)
                {
                    resultat = pris * 0.20;
                }
                // hvis prisen er højere end nul men størrer end eller lig med 200.000 kr.
                if (pris <= 200000)
                {
                    resultat = pris * 0.20 - 130000;
                }

                // konvertere vores double til en int og returnere resultatet
                return Convert.ToInt32(resultat);
            }
            // hvis prisen er mindre eller lig med nul, kastes en undtagelese ud med en fejlbesked
            throw new System.ArgumentOutOfRangeException("Pris: ", pris, "Det er ikke muligt at beregne prisen på elbilen, da prisen enten er 0 eller i minus. Prøv igen!");

        }
    }
}
