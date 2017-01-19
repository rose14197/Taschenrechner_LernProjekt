﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class RechnerModel
    {
        public double Berechne(double ersteZahl, double zweiteZahl, string operatoren)
        {
            double ergebnis = 0;

            switch (operatoren)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren
                    ergebnis = Addiere(ersteZahl, zweiteZahl);

                    //Ausgabe des Ergebnis
                    //Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "*":
                    ergebnis = Multipliziere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "/":
                    ergebnis = Dividiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);

                    break;


                default:
                    ergebnis = 0;

                    break;
            }
            return ergebnis;
        }



        //Ausgabe


        //Methode Addiere mit Rückgabewert
        private double Addiere(double ersterSummandalsZahl, double zweiterSummandalsZahl)
        {
            double summe = ersterSummandalsZahl + zweiterSummandalsZahl;
            return summe;
        }

        //Methode Subtrahiere mit Rückgabewert
        private double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;
            return differenz;
        }

        private double Dividiere(double basis, double divident)
        {
            double resultat = basis / divident;
            return resultat;
        }

        private double Multipliziere(double multiplient, double basis)
        {
            double multiplikat = multiplient * basis;
            return multiplikat;

        }



    }
}